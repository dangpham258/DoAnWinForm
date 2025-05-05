using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BusinessLogic;
using DataTransferObject;

namespace Presentation
{
    public partial class TicketCancelForm : Form
    {
        public TicketCancelForm()
        {
            InitializeComponent();
        }

        private void TicketCancelForm_Load(object sender, EventArgs e)
        {
            try
            {
                string currentUser = PersonLoginSession.CurrentPerson.UserName;

                CheckTicketInformation ticketBL = new CheckTicketInformation();
                DataTable dtCurrentTickets = ticketBL.GetCurrentNotUseTicket(currentUser);

                DGVTicket.DataSource = dtCurrentTickets;
                FormatDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu vé: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            PassengerLoginForm next = new PassengerLoginForm();
            next.Show();
            this.Hide();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (DGVTicket.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một vé để hủy.", "Thông báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc muốn hủy vé đã chọn?", "Xác nhận",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            try
            {
                string ticketID = DGVTicket.SelectedRows[0].Cells["TicketID"].Value.ToString();

                // Sử dụng BusinessLogic thay vì truy cập trực tiếp đến database
                CheckTicketInformation ticketBL = new CheckTicketInformation();
                bool success = ticketBL.CancelTicket(ticketID);

                if (success)
                {
                    MessageBox.Show("Hủy vé thành công!", "Thành công",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật lại datagridview sau khi hủy vé
                    string currentUser = PersonLoginSession.CurrentPerson.UserName;
                    DataTable dtCurrentTickets = ticketBL.GetCurrentNotUseTicket(currentUser);
                    DGVTicket.DataSource = dtCurrentTickets;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy vé để hủy.", "Thông báo",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hủy vé: " + ex.Message, "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDataGridView()
        {
            DGVTicket.ClearSelection();
            DGVTicket.Columns["FlightNumber"].HeaderText = "Mã chuyến bay";
            DGVTicket.Columns["Airline"].HeaderText = "Hãng bay";
            DGVTicket.Columns["DepartCode"].HeaderText = "Sân bay đi";
            DGVTicket.Columns["ArriveCode"].HeaderText = "Sân bay đến";
            DGVTicket.Columns["DepartureDate"].HeaderText = "Ngày khởi hành";
            DGVTicket.Columns["ArrivalDate"].HeaderText = "Ngày đến";
            DGVTicket.Columns["ClassType"].HeaderText = "Hạng vé";
            DGVTicket.Columns["SeatNumber"].HeaderText = "Số ghế";
            DGVTicket.Columns["Price"].HeaderText = "Giá vé";
            DGVTicket.Columns["FullName"].HeaderText = "Họ tên";

            DGVTicket.Columns["Status"].Visible = false;
            DGVTicket.Columns["TicketID"].Visible = false;
            DGVTicket.Columns["PhoneNumber"].Visible = false;
            DGVTicket.Columns["CCCD"].Visible = false;

            DGVTicket.Columns["DepartureDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            DGVTicket.Columns["ArrivalDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            DGVTicket.Columns["Price"].DefaultCellStyle.Format = "N0";

            DGVTicket.AutoResizeColumns();
        }
    }
}
