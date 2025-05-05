using BusinessLogic;
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
                "Lỗi thanh toán",
                "Góp ý tính năng",
                "Thắc mắc",
                "Khác"
            });
            cbbType.SelectedIndex = 0;

            radioBtnNo.Checked = true;

            LoadAllToDGVFeedback();

            //Khóa các ô nhập liệu
            richTxtDetail.Enabled = false;
            richTxtDetail.ForeColor = Color.Black;
        }

        private void LoadAllToDGVFeedback()
        {
            try
            {
                CheckForLoadToDGV load = new CheckForLoadToDGV();
                DataTable dt = load.ForAllFeedback();
                DGVFeedback.DataSource = dt;
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
                        fbManage.SeenFeedback(fb, true);
                    else
                        fbManage.SeenFeedback(fb, false);

                    richTxtDetail.Text = $"{fullname}\n{phoneNumber}\nPhản hồi: {cbbType.Text}\n\nChi tiết: {detail}";
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
                LoadAllToDGVFeedback();
                radioBtnNotSeen.Checked = false;
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            ControllerLoginForm back = new ControllerLoginForm();
            back.Show();
            this.Hide();
        }
    }
}
