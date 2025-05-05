using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataTransferObject;
using BusinessLogic;
using System.Windows.Forms.VisualStyles;

namespace Presentation
{
    public partial class TicketHistoryForm : Form
    {
        private CheckTicketInformation ticketBusiness;

        public TicketHistoryForm()
        {
            InitializeComponent();
            ticketBusiness = new CheckTicketInformation();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PassengerLoginForm next = new PassengerLoginForm();
            next.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string currentUser = PersonLoginSession.CurrentPerson.UserName;

            string name = txtName.Text.Trim();
            string diemDi = cbbDiemdi.SelectedIndex > 0 ? cbbDiemdi.SelectedValue?.ToString() : null;
            string diemDen = cbbDiemden.SelectedIndex > 0 ? cbbDiemden.SelectedValue?.ToString() : null;
            string hangBay = txtHang.Text.Trim();
            string date = checkBoxDate.Checked
                                 ? dateTimePicker.Value.ToString("yyyy-MM-dd")
                                 : null;

            // Chỉ lấy ngày nếu người dùng đã chọn
            if (checkBoxDate.Checked)
            {
                date = dateTimePicker.Value.ToString("yyyy-MM-dd");
            }

            // Kiểm tra xem người dùng có chọn trùng điểm đi và điểm đến không
            if (!string.IsNullOrEmpty(diemDi) && !string.IsNullOrEmpty(diemDen) && diemDi == diemDen)
            {
                MessageBox.Show("Điểm đi và điểm đến không được trùng nhau!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SearchTickets(currentUser, name, diemDi, diemDen, hangBay, date);
        }

        private void SearchTickets(string userName, string name, string diemDi, string diemDen, string hangBay, string date)
        {
            try
            {
                DataTable dt = ticketBusiness.GetTicketHistory(userName, name, diemDi, diemDen, hangBay, date);
                DGVHistoryTicket.Columns.Clear();
                DataView dv = dt.DefaultView;
                dv.Sort = "Status ASC";
                DGVHistoryTicket.DataSource = dv;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy vé nào phù hợp với thông tin đã nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    FormatDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm vé: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TicketHistoryForm_Load(object sender, EventArgs e)
        {
            checkBoxDate.Checked = false;
            checkBoxDate.CheckedChanged += (s, ev) => {
                dateTimePicker.Enabled = checkBoxDate.Checked;
            };
            dateTimePicker.Enabled = false;

            // Tạo danh sách cho combo box với tùy chọn trống đầu tiên
            DataTable airportsTable = new DataTable();
            airportsTable.Columns.Add("Code", typeof(string));
            airportsTable.Columns.Add("City", typeof(string));

            // Thêm lựa chọn trống đầu tiên
            airportsTable.Rows.Add("", "-- Chọn --");

            // Thêm dữ liệu từ AirportData
            foreach (var airport in AirportData.Airports)
            {
                airportsTable.Rows.Add(airport.Code, airport.City);
            }

            // Thiết lập ComboBox Điểm đi
            cbbDiemdi.DataSource = airportsTable;
            cbbDiemdi.DisplayMember = "City";
            cbbDiemdi.ValueMember = "Code";
            cbbDiemdi.SelectedIndex = 0;

            // Thiết lập ComboBox Điểm đến với một bản sao của dữ liệu
            DataTable airportsTable2 = airportsTable.Copy();
            cbbDiemden.DataSource = airportsTable2;
            cbbDiemden.DisplayMember = "City";
            cbbDiemden.ValueMember = "Code";
            cbbDiemden.SelectedIndex = 0;

            // Thiết lập DateTimePicker
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "dddd, dd/MM/yyyy";
        }

        private void FormatDataGridView()
        {
            DGVHistoryTicket.CurrentCell = null;
            DGVHistoryTicket.Columns["FlightNumber"].HeaderText = "Mã chuyến bay";
            DGVHistoryTicket.Columns["Airline"].HeaderText = "Hãng bay";
            DGVHistoryTicket.Columns["DepartCode"].HeaderText = "Sân bay đi";
            DGVHistoryTicket.Columns["ArriveCode"].HeaderText = "Sân bay đến";
            DGVHistoryTicket.Columns["DepartureDate"].HeaderText = "Ngày khởi hành";
            DGVHistoryTicket.Columns["ArrivalDate"].HeaderText = "Ngày đến";
            DGVHistoryTicket.Columns["ClassType"].HeaderText = "Hạng vé";
            DGVHistoryTicket.Columns["SeatNumber"].HeaderText = "Số ghế";
            DGVHistoryTicket.Columns["Price"].HeaderText = "Giá vé";
            DGVHistoryTicket.Columns["FullName"].HeaderText = "Họ tên";
            DGVHistoryTicket.Columns["Status"].HeaderText = "Trạng thái";

            DGVHistoryTicket.Columns["TicketID"].Visible = false;
            DGVHistoryTicket.Columns["PhoneNumber"].Visible = false;
            DGVHistoryTicket.Columns["CCCD"].Visible = false;

            DGVHistoryTicket.Columns["DepartureDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            DGVHistoryTicket.Columns["ArrivalDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            DGVHistoryTicket.Columns["Price"].DefaultCellStyle.Format = "N0";

            if (!DGVHistoryTicket.Columns.Contains("StatusText"))
            {
                var col = new DataGridViewTextBoxColumn();
                col.Name = "StatusText";
                col.HeaderText = "Trạng thái";
                DGVHistoryTicket.Columns.Add(col);
            }

            // Gán giá trị text cho từng dòng dựa trên cột Status (Int32)
            foreach (DataGridViewRow row in DGVHistoryTicket.Rows)
            {
                if (row.Cells["Status"].Value != null)
                {
                    int st = Convert.ToInt32(row.Cells["Status"].Value);
                    string text;
                    switch (st)
                    {
                        case 0:
                            text = "Chưa sử dụng";
                            // giữ màu mặc định
                            break;
                        case 1:
                            text = "Đã sử dụng";
                            // xanh lá nhạt
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                            break;
                        case 2:
                            text = "Đã hủy";
                            // đỏ nhạt
                            row.DefaultCellStyle.BackColor = Color.LightCoral;
                            break;
                        default:
                            text = "Không xác định";
                            break;
                    }
                    row.Cells["StatusText"].Value = text;
                }
            }
            // Ẩn cột Status gốc
            DGVHistoryTicket.Columns["Status"].Visible = false;

            DGVHistoryTicket.AutoResizeColumns();
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            int fromIndex = cbbDiemdi.SelectedIndex;
            int toIndex = cbbDiemden.SelectedIndex;

            // Hoán đổi
            cbbDiemdi.SelectedIndex = toIndex;
            cbbDiemden.SelectedIndex = fromIndex;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            int selectionStart = txt.SelectionStart;
            string filtered = new string(txt.Text.Where(c => char.IsLetter(c) && c <= 'z' || c == ' ').ToArray());
            txt.Text = filtered.ToUpper();
            txt.SelectionStart = selectionStart;
        }
    }
}