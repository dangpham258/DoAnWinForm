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
    public partial class BookingInformationForm : Form
    {
        public BookingInformationForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BookingFlightChooseForm next = new BookingFlightChooseForm();
            next.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập vào
            string error = CheckBookingInformationForm.Validate(txtHoten.Text, txtSdt.Text, txtCccd.Text);
            if (error != null)
            {
                MessageBox.Show(error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Cập nhật thông tin vào đối tượng vé hiện tại
            BookingSession.CurrentTicket.FullName = txtHoten.Text.Trim();
            BookingSession.CurrentTicket.PhoneNumber = txtSdt.Text.Trim();
            BookingSession.CurrentTicket.CCCD = txtCccd.Text.Trim();

            SeatBookForm next = new SeatBookForm();
            next.Show();
            this.Hide();
        }

        private void txtHoten_TextChanged(object sender, EventArgs e)
        {
            // Chỉ cho phép chữ cái không dấu và khoảng trắng
            TextBox txt = sender as TextBox;
            int selectionStart = txt.SelectionStart;
            string filtered = new string(txt.Text.Where(c => char.IsLetter(c) && c <= 'z' || c == ' ').ToArray());
            txt.Text = filtered.ToUpper();
            txt.SelectionStart = selectionStart;
        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập số
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

        private void txtCccd_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập số
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

        private void BookingInformationForm_Load(object sender, EventArgs e)
        {
            lblDiemDi.Text = BookingSession.CurrentTicket.DepartCode;
            lblDiemDen.Text = BookingSession.CurrentTicket.ArriveCode;
        }
    }
}
