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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentation
{
    public partial class SeatBookForm : Form
    {
        public SeatBookForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BookingInformationForm next = new BookingInformationForm();
            next.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có ghế nào được chọn chưa
            string selectedSeat = GetSelectedSeat();
            if (string.IsNullOrEmpty(selectedSeat))
            {
                MessageBox.Show("Vui lòng chọn ghế trước khi tiếp tục!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lưu thông tin ghế đã chọn
            BookingSession.CurrentTicket.SeatNumber = selectedSeat;

            // Chuyển sang form xác nhận
            BookingConfirmForm next = new BookingConfirmForm();
            next.Show();
            this.Hide();
        }

        // Phương thức lấy ghế được chọn từ các RadioButton
        private string GetSelectedSeat()
        {
            // Kiểm tra từng RadioButton trong GroupBox
            foreach (Control control in groupBox1.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    // Lấy số ghế từ tên của RadioButton (thường là "radioButton1", "radioButton2",...)
                    string buttonName = radioButton.Name;
                    string seatNumber = "G" + buttonName.Substring(11); // Chuyển đổi "radioButton1" -> "G1"
                    return seatNumber;
                }
            }
            return null;
        }

        private void SeatBookForm_Load(object sender, EventArgs e)
        {
            CheckSeat seatBUS = new CheckSeat();
            var ticket = BookingSession.CurrentTicket;

            Dictionary<string, bool> seatStatus = seatBUS.GetSeatStatus(
                ticket.FlightNumber,
                ticket.DepartureDate,
                ticket.ArrivalDate
            );

            foreach (Control control in groupBox1.Controls)
            {
                if (control is RadioButton rb)
                {
                    string seatName = "G" + rb.Name.Substring(11); // "radioButton1" => G1
                    if (seatStatus.ContainsKey(seatName) && seatStatus[seatName])
                    {
                        rb.Enabled = false;
                        rb.ForeColor = Color.Gray; // Tùy chọn: đổi màu cho dễ nhìn
                    }
                }
            }
        }
    }
}
