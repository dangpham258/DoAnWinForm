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
    public partial class ReportFlightChooseForm : Form
    {
        public ReportFlightChooseForm()
        {
            InitializeComponent();
            LoadToFlightGridView();
        }

        private void LoadToFlightGridView()
        {
            try
            {
                CheckForLoadToDGV loadToDGV = new CheckForLoadToDGV();
                DataTable dt = loadToDGV.ForReportFlight(true);
                flightDGV.DataSource = dt;
            }
            catch (Exception ex)
            {
                string message = "Lỗi tải chuyến bay: " + ex.Message;
                if (ex.InnerException != null)
                    message += "\nChi tiết: " + ex.InnerException.Message;
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                int? flightId = null;
                if (!string.IsNullOrWhiteSpace(txtFlightID.Text)
                    && int.TryParse(txtFlightID.Text, out int id))
                {
                    flightId = id;
                }

                DateTime? date = checkBoxDate.Checked
                    ? flightDatePicker.Value.Date
                    : (DateTime?)null;

                CheckForLoadToDGV loadToDGV = new CheckForLoadToDGV();
                flightDGV.DataSource = loadToDGV.ForReportFlight(false, flightId, date);               
            }
            catch (Exception ex)
            {
                string msg = "Lỗi khi tìm chuyến bay: " + ex.Message;
                if (ex.InnerException != null)
                    msg += "\nChi tiết: " + ex.InnerException.Message;
                MessageBox.Show(msg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMakeReport_Click(object sender, EventArgs e)
        {
            if (flightDGV.SelectedRows.Count == 0 || string.IsNullOrWhiteSpace(txtFlightID.Text))
            {
                MessageBox.Show("Vui lòng chọn chuyến bay", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                FlightInfo flight = new FlightInfo();
                flight.FlightID = int.Parse(txtFlightID.Text);

                Report next = new Report(flight);
                next.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy thông tin từ DRV: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ControllerLoginForm back = new ControllerLoginForm();
            back.Show();
            this.Hide();
        }

        private void txtFlightID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void flightDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào ô hợp lệ trong hàng không
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = flightDGV.Rows[e.RowIndex];

                txtFlightID.Text = selectedRow.Cells[0].Value?.ToString() ?? "";

                object dateValue = selectedRow.Cells[5].Value;
                if (dateValue != null && DateTime.TryParse(dateValue.ToString(), out DateTime flightDate))
                {
                    flightDatePicker.Value = flightDate;
                }
                else
                {
                    MessageBox.Show("Ngày không hợp lệ hoặc bị trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void checkBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDate.Checked)
            {
                flightDatePicker.Enabled = true;
            }
            else
            {
                flightDatePicker.Enabled = false;
                flightDatePicker.Value = DateTime.Today;
            }
        }

        private void ReportFlightChooseForm_Load(object sender, EventArgs e)
        {
            FormatDataGridView();
        }

        private void FormatDataGridView()
        {
            flightDGV.ClearSelection();
            flightDGV.Columns["FlightID"].HeaderText = "Mã chuyến bay";
            flightDGV.Columns["FlightNumber"].HeaderText = "Số hiệu";
            flightDGV.Columns["Airline"].HeaderText = "Hãng bay";
            flightDGV.Columns["DepartCode"].HeaderText = "Sân bay đi";
            flightDGV.Columns["ArriveCode"].HeaderText = "Sân bay đến";
            flightDGV.Columns["DepartureDate"].HeaderText = "Ngày khởi hành";
            flightDGV.Columns["ArrivalDate"].HeaderText = "Ngày đến";
            flightDGV.Columns["PilotName"].HeaderText = "Phi công";
            flightDGV.Columns["CoPilotName"].HeaderText = "Cơ phó";
            flightDGV.Columns["PassengerCount"].HeaderText = "Số hành khách";
            flightDGV.Columns["AttendantName"].HeaderText = "Tiếp viên";

            flightDGV.Columns["PilotID"].Visible = false;
            flightDGV.Columns["CoPilotID"].Visible = false;
            flightDGV.Columns["AttendantID"].Visible = false;

            flightDGV.Columns["DepartureDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            flightDGV.Columns["ArrivalDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            flightDGV.AutoResizeColumns();
        }
    }
}
