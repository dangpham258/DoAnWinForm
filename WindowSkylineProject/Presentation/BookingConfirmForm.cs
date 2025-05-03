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
    public partial class BookingConfirmForm : Form
    {
        public BookingConfirmForm()
        {
            InitializeComponent();
        }

        private void BookingConfirmForm_Load(object sender, EventArgs e)
        {
            // Hiển thị tất cả thông tin lên các label
            if (BookingSession.CurrentTicket != null)
            {
                // Thông tin hành khách
                lblHoTen.Text = $"Ông/Bà: {BookingSession.CurrentTicket.FullName}";
                lblSDT.Text = $"Số điện thoại: {BookingSession.CurrentTicket.PhoneNumber}";
                lblCCCD.Text = $"Căn cước công dân: {BookingSession.CurrentTicket.CCCD}";

                // Thông tin chuyến bay
                lblHanhTrinh.Text = $"Bay từ: {BookingSession.CurrentTicket.DepartCode} - Bay đến: {BookingSession.CurrentTicket.ArriveCode}";
                lblChuyenBay.Text = $"Mã chuyến bay: {BookingSession.CurrentTicket.FlightNumber} - Hãng hàng không: {BookingSession.CurrentTicket.Airline}";

                // Thời gian bay và hạ cánh
                lblThoiGian.Text = $"Giờ bay: {BookingSession.CurrentTicket.DepartureDate:dd/MM/yyyy HH:mm} - Giờ hạ cánh: {BookingSession.CurrentTicket.ArrivalDate:dd/MM/yyyy HH:mm}";

                // Hạng ghế và số ghế
                lblHangBay.Text = $"Hạng bay: {BookingSession.CurrentTicket.ClassType}";
                lblSoGhe.Text = $"Số ghế: {BookingSession.CurrentTicket.SeatNumber}";

                // Hiển thị giá vé
                lblGia.Text = $"Giá vé: {BookingSession.CurrentTicket.Price:N0} VND";
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            Ticket ticket = BookingSession.CurrentTicket;
            FlightInfo flightInfo = new FlightInfo(
                ticket.FlightNumber,
                ticket.Airline,
                ticket.DepartCode,
                ticket.ArriveCode,
                ticket.DepartureDate,
                ticket.ArrivalDate
            );

            if (ticket != null)
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult dialogResult = MessageBox.Show(
                    "Bạn có chắc chắn muốn xác nhận đặt vé?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // Kiểm tra kết quả xác nhận
                if (dialogResult == DialogResult.No)
                {
                    return;
                }

                CheckTicketInformation bus = new CheckTicketInformation();
                bool result = bus.SaveTicket(ticket);
                bool isFlightAdded = bus.SaveFlight(flightInfo, ticket.SeatNumber);

                if (result && isFlightAdded)
                {
                    MessageBox.Show("Đặt vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PassengerLoginForm next = new PassengerLoginForm();
            next.Show();
            this.Hide();
        }
                else
                {
                    MessageBox.Show("Đặt vé thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            SeatBookForm next = new SeatBookForm();
            next.Show();
            this.Hide();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Bạn có chắc chắn muốn hủy đặt vé?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            PassengerLoginForm next = new PassengerLoginForm();
            next.Show();
            this.Hide();
        }
    }
}
