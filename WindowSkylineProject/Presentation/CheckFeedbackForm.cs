﻿using BusinessLogic;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class CheckFeedbackForm : Form
    {
        public CheckFeedbackForm()
        {
            InitializeComponent();

            cbbType.Items.AddRange(new[]
           {
                "Lỗi đặt vé",
                "Lỗi hệ thống",
                "Góp ý tính năng",
                "Thắc mắc",
                "Khác"
            });
            cbbType.SelectedIndex = 0;

            radioBtnNo.Checked = true;
            
            LoadNotSeenToDGVFeedback();

            //Khóa các ô nhập liệu
            richTxtDetail.Enabled = false;
            richTxtDetail.ForeColor = Color.Black;
            FormatDataGridView();
        }

        private void FormatDataGridView()
        {
            DGVFeedback.Columns[0].HeaderText = "Mã Phản Hồi";
            DGVFeedback.Columns[1].HeaderText = "Họ Tên";
            DGVFeedback.Columns[2].HeaderText = "Số Điện Thoại";
            DGVFeedback.Columns[3].HeaderText = "Loại Phản Hồi";
            DGVFeedback.Columns[4].HeaderText = "Chi Tiết";
            DGVFeedback.Columns[5].HeaderText = "Trạng Thái";
            DGVFeedback.Columns[5].DefaultCellStyle.Format = "N0";

            DGVFeedback.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGVFeedback.EnableHeadersVisualStyles = false;
            DGVFeedback.CellFormatting += DGVFeedback_CellFormatting;
        }
        private void DGVFeedback_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.Value != null)
            {
                if (e.Value.ToString() == "0")
                {
                    e.Value = "Chưa xem";
                }
                else if (e.Value.ToString() == "1")
                {
                    e.Value = "Đã xem";
                    e.CellStyle.ForeColor = Color.Green;
                }
                e.FormattingApplied = true;
            }
        }

        private void LoadNotSeenToDGVFeedback()
        {
            try
            {
                CheckForLoadToDGV load = new CheckForLoadToDGV();
                DataTable dt = load.ForCheckFeedback();
                DGVFeedback.DataSource = dt;
                if (DGVFeedback.Columns.Count > 0)
                    FormatDataGridView();
            }
            catch (Exception ex)
            {
                string message = "Lỗi tải phản hồi: " + ex.Message;
                if (ex.InnerException != null)
                    message += "\nChi tiết: " + ex.InnerException.Message;

                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBaseOnFilter()
        {
            try
            {
                CheckForLoadToDGV load = new CheckForLoadToDGV();
                DataTable dt = load.ForFeedbackWithFilter(cbbType.Text, radioBtnYes.Checked);
                DGVFeedback.DataSource = dt;
                if (DGVFeedback.Columns.Count > 0)
                    FormatDataGridView();
            }
            catch (Exception ex)
            {
                string message = "Lỗi tải phản hồi: " + ex.Message;
                if (ex.InnerException != null)
                    message += "\nChi tiết: " + ex.InnerException.Message;
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            richTxtDetail.Clear();
            LoadBaseOnFilter();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            ControllerLoginForm back = new ControllerLoginForm();
            back.Show();
            this.Hide();
        }

        private void DGVFeedback_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow selectedRow = DGVFeedback.Rows[e.RowIndex];

                    int feedbackId = int.Parse(selectedRow.Cells[0].Value.ToString());
                    string fullname = selectedRow.Cells[1].Value.ToString();
                    string phoneNumber = selectedRow.Cells[2].Value.ToString();
                    cbbType.SelectedValue = selectedRow.Cells[3].Value.ToString();
                    string detail = selectedRow.Cells[4].Value?.ToString() ?? "";

                    FeedbackManage fbManage = new FeedbackManage();
                    Feedback fb = new Feedback(fullname, phoneNumber, cbbType.Text, detail) { FeedbackId = feedbackId };
                    if (radioBtnNotSeen.Checked)
                    {
                        fbManage.SeenFeedback(fb, true);
                        radioBtnNo.Checked = true;
                    }
                    else
                    {
                        fbManage.SeenFeedback(fb, false);
                        radioBtnNo.Checked = true;
                    }
                    richTxtDetail.Text = $"Họ tên: {fullname}\nSố điện thoại: {phoneNumber}\nLoại phản hồi: {cbbType.Text}\n\nChi tiết: {detail}";
                }
            }
            catch (Exception ex)
            {
                string message = "Lỗi tải phản hồi: " + ex.Message;
                if (ex.InnerException != null)
                    message += "\nChi tiết: " + ex.InnerException.Message;
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadNotSeenToDGVFeedback();
                radioBtnNotSeen.Checked = false;
            }
        }

        private void CheckFeedbackForm_Load(object sender, EventArgs e)
        {
        }
    }
}
