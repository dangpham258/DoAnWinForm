using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using DataTransferObject;

namespace Presentation
{
    public partial class SeatChangeForm : Form
    {
        public SeatChangeForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PassengerLoginForm next = new PassengerLoginForm();
            next.Show();
            this.Hide();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng đã chọn vé chưa
                if (DGVCurrentTicket.SelectedRows.Count == 0 && DGVCurrentTicket.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn vé cần đổi ghế!", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy thông tin vé từ dòng được chọn
                int rowIndex = DGVCurrentTicket.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = DGVCurrentTicket.Rows[rowIndex];

                string ticketID = selectedRow.Cells["TicketID"].Value.ToString();
                string flightNumber = selectedRow.Cells["FlightNumber"].Value.ToString();
                DateTime departureDate = Convert.ToDateTime(selectedRow.Cells["DepartureDate"].Value);
                DateTime arrivalDate = Convert.ToDateTime(selectedRow.Cells["ArrivalDate"].Value);
                string currentSeat = selectedRow.Cells["SeatNumber"].Value.ToString();

                // Tìm ghế mới được chọn
                string newSeatNumber = "";
                foreach (Control control in groupBox1.Controls)
                {
                    if (control is RadioButton rb && rb.Checked)
                    {
                        // Chuyển đổi tên RadioButton thành mã ghế (ví dụ: "radioButton1" => "G1")
                        newSeatNumber = "G" + rb.Name.Substring(11);
                        break;
                    }
                }

                // Kiểm tra xem đã chọn ghế mới chưa
                if (string.IsNullOrEmpty(newSeatNumber))
                {
                    MessageBox.Show("Vui lòng chọn ghế muốn đổi!", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xác nhận thay đổi ghế
                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn đổi từ ghế {currentSeat} sang ghế {newSeatNumber}?",
                    "Xác nhận đổi ghế", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Gọi phương thức đổi ghế từ Business Logic
                    CheckSeat seatBL = new CheckSeat();
                    bool success = seatBL.ChangeSeat(ticketID, newSeatNumber, flightNumber, departureDate, arrivalDate);

                    if (success)
                    {
                        MessageBox.Show($"Đổi ghế thành công từ {currentSeat} sang {newSeatNumber}!",
                                       "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Cập nhật lại danh sách vé hiện tại
                        SeatChangeForm_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Đổi ghế không thành công. Vui lòng thử lại sau!",
                                       "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi đổi ghế: {ex.Message}",
                               "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SeatChangeForm_Load(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Visible = false;
                lblShowGhe.Visible = false;
                string currentUser = PersonLoginSession.CurrentPerson.UserName;

                // Lấy danh sách vé chưa sử dụng
                CheckTicketInformation ticketBL = new CheckTicketInformation();
                DataTable dtCurrentTickets = ticketBL.GetCurrentNotUseTicket(currentUser);

                // Hiển thị lên DataGridView
                DGVCurrentTicket.DataSource = dtCurrentTickets;

                if (DGVCurrentTicket.Columns.Count > 0)
                {
                    FormatDataGridView();
                    DGVCurrentTicket.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu vé: " + ex.Message, "Lỗi",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDataGridView()
        {
            DGVCurrentTicket.Columns["FlightNumber"].HeaderText = "Mã chuyến bay";
            DGVCurrentTicket.Columns["Airline"].HeaderText = "Hãng bay";
            DGVCurrentTicket.Columns["DepartCode"].HeaderText = "Sân bay đi";
            DGVCurrentTicket.Columns["ArriveCode"].HeaderText = "Sân bay đến";
            DGVCurrentTicket.Columns["DepartureDate"].HeaderText = "Ngày khởi hành";
            DGVCurrentTicket.Columns["ArrivalDate"].HeaderText = "Ngày đến";
            DGVCurrentTicket.Columns["ClassType"].HeaderText = "Hạng vé";
            DGVCurrentTicket.Columns["SeatNumber"].HeaderText = "Số ghế";
            DGVCurrentTicket.Columns["Price"].HeaderText = "Giá vé";
            DGVCurrentTicket.Columns["FullName"].HeaderText = "Họ tên";

            DGVCurrentTicket.Columns["TicketID"].Visible = false;
            DGVCurrentTicket.Columns["PhoneNumber"].Visible = false;
            DGVCurrentTicket.Columns["CCCD"].Visible = false;
            DGVCurrentTicket.Columns["Status"].Visible = false;

            DGVCurrentTicket.Columns["DepartureDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            DGVCurrentTicket.Columns["ArrivalDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            DGVCurrentTicket.Columns["Price"].DefaultCellStyle.Format = "N0";

            DGVCurrentTicket.AutoResizeColumns();
        }
        private void DGVCurrentTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                groupBox1.Visible = true;
                lblShowGhe.Visible = true;
                // Lấy thông tin vé từ dòng được chọn trong DataGridView
                DataGridViewRow selectedRow = DGVCurrentTicket.Rows[e.RowIndex];

                // Lấy các giá trị cần thiết từ dòng đã chọn
                string flightNumber = selectedRow.Cells["FlightNumber"].Value.ToString();
                DateTime departureDate = Convert.ToDateTime(selectedRow.Cells["DepartureDate"].Value);
                DateTime arrivalDate = Convert.ToDateTime(selectedRow.Cells["ArrivalDate"].Value);

                // Khởi tạo đối tượng kiểm tra trạng thái ghế
                CheckSeat seatBUS = new CheckSeat();

                // Lấy trạng thái ghế cho chuyến bay đã chọn
                Dictionary<string, bool> seatStatus = seatBUS.GetSeatStatus(
                    flightNumber,
                    departureDate,
                    arrivalDate
                );

                // Cập nhật hiển thị các RadioButton dựa trên trạng thái ghế
                foreach (Control control in groupBox1.Controls)
                {
                    if (control is RadioButton rb)
                    {
                        // Reset trạng thái của tất cả RadioButton trước khi cập nhật
                        rb.Enabled = true;
                        rb.ForeColor = SystemColors.ControlText;

                        // Chuyển đổi tên RadioButton thành mã ghế (ví dụ: "radioButton1" => "G1")
                        string seatName = "G" + rb.Name.Substring(11).PadLeft(1, '0');

                        // Vô hiệu hóa RadioButton cho ghế đã được đặt
                        if (seatStatus.ContainsKey(seatName) && seatStatus[seatName])
                        {
                            rb.Enabled = false;
                            rb.ForeColor = Color.Gray;
                        }
                    }
                }
            }
        }
    }
}
