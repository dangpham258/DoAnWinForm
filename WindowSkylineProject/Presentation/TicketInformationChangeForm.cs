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
    public partial class TicketInformationChangeForm : Form
    {
        private string origFullName;
        private string origPhone;
        private string origCCCD;

        public TicketInformationChangeForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PassengerLoginForm next = new PassengerLoginForm();
            next.Show();
            this.Hide();
        }

        private void TicketInformationChangeForm_Load(object sender, EventArgs e)
        {
            try
            {
                string currentUser = PersonLoginSession.CurrentPerson.UserName;

                CheckTicketInformation ticketBL = new CheckTicketInformation();
                DataTable dtCurrentTickets = ticketBL.GetCurrentNotUseTicket(currentUser);

                DGVTicket.DataSource = dtCurrentTickets;
                FormatDataGridView();
                this.Tag = null;     // reset TicketID
                txtHoten.Clear();
                txtSdt.Clear();
                txtCccd.Clear();
                DGVTicket.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu vé: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDataGridView()
        {
            DGVTicket.Columns["FlightNumber"].HeaderText = "Mã chuyến bay";
            DGVTicket.Columns["Airline"].HeaderText = "Hãng bay";
            DGVTicket.Columns["DepartCode"].HeaderText = "Sân bay đi";
            DGVTicket.Columns["ArriveCode"].HeaderText = "Sân bay đến";
            DGVTicket.Columns["DepartureDate"].HeaderText = "Ngày khởi hành";
            DGVTicket.Columns["ArrivalDate"].HeaderText = "Ngày đến";
            DGVTicket.Columns["SeatNumber"].HeaderText = "Số ghế";
            DGVTicket.Columns["Price"].HeaderText = "Giá vé";
            DGVTicket.Columns["FullName"].HeaderText = "Họ tên";
            DGVTicket.Columns["PhoneNumber"].HeaderText = "SĐT";

            DGVTicket.Columns["Status"].Visible = false;
            DGVTicket.Columns["TicketID"].Visible = false;
            DGVTicket.Columns["ClassType"].Visible = false;

            DGVTicket.Columns["DepartureDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            DGVTicket.Columns["ArrivalDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            DGVTicket.Columns["Price"].DefaultCellStyle.Format = "N0";
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (!(this.Tag is string ticketID))
            {
                MessageBox.Show("Vui lòng chọn một vé trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hoten = txtHoten.Text.Trim();
            string sdt = txtSdt.Text.Trim();
            string cccd = txtCccd.Text.Trim();

            if (string.IsNullOrEmpty(hoten) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(cccd))
            {
                MessageBox.Show("Không được để trống Họ tên / SĐT / CCCD", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (sdt.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSdt.Focus();
                return;
            }
            if (cccd.Length != 12)
            {
                MessageBox.Show("CCCD phải hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCccd.Focus();
                return;
            }
            if (hoten == origFullName && sdt == origPhone && cccd == origCCCD)
            {
                MessageBox.Show("Bạn chưa thay đổi thông tin nào cả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var ticketBL = new CheckTicketInformation();
                bool ok = ticketBL.UpdatePassengerInfo(ticketID, hoten, sdt, cccd);
                if (ok)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TicketInformationChangeForm_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thay đổi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DGVTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = DGVTicket.Rows[e.RowIndex];

            txtHoten.Text = origFullName = row.Cells["FullName"].Value.ToString();
            txtSdt.Text = origPhone = row.Cells["PhoneNumber"].Value.ToString();
            txtCccd.Text = origCCCD = row.Cells["CCCD"].Value.ToString();

            // Lưu TicketID vào Tag
            this.Tag = row.Cells["TicketID"].Value.ToString();
        }

        private void txtHoten_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            int selectionStart = txt.SelectionStart;
            string filtered = new string(txt.Text.Where(c => char.IsLetter(c) && c <= 'z' || c == ' ').ToArray());
            txt.Text = filtered.ToUpper();
            txt.SelectionStart = selectionStart;
        }

        private void txtCccd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Giới hạn 12 số
            if (char.IsDigit(e.KeyChar) && ((sender as TextBox).Text.Length >= 12))
            {
                e.Handled = true;
            }
        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Giới hạn 10 số
            if (char.IsDigit(e.KeyChar) && ((sender as TextBox).Text.Length >= 10))
            {
                e.Handled = true;
            }
        }
    }
}
