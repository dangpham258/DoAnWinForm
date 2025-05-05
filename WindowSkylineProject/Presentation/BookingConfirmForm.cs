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
                lblHoTen.Text = $"Ông/Bà: {BookingSession.CurrentTicket.FullName}";
                lblSDT.Text = $"Số điện thoại: {BookingSession.CurrentTicket.PhoneNumber}";
                lblCCCD.Text = $"Căn cước công dân: {BookingSession.CurrentTicket.CCCD}";

                string departCity = AirportData.Airports.FirstOrDefault(a => a.Code == BookingSession.CurrentTicket.DepartCode)?.City ?? BookingSession.CurrentTicket.DepartCode;
                string arriveCity = AirportData.Airports.FirstOrDefault(a => a.Code == BookingSession.CurrentTicket.ArriveCode)?.City ?? BookingSession.CurrentTicket.ArriveCode;
                lblHanhTrinh.Text = $"Bay từ: {departCity} - Bay đến: {arriveCity}";
                lblChuyenBay.Text = $"Mã chuyến bay: {BookingSession.CurrentTicket.FlightNumber} - Hãng hàng không: {BookingSession.CurrentTicket.Airline}";
                lblThoiGian.Text = $"Giờ bay: {BookingSession.CurrentTicket.DepartureDate:dd/MM/yyyy HH:mm} - Giờ hạ cánh: {BookingSession.CurrentTicket.ArrivalDate:dd/MM/yyyy HH:mm}";
                lblHangBay.Text = $"Hạng bay: {BookingSession.CurrentTicket.ClassType}";
                lblSoGhe.Text = $"Số ghế: {BookingSession.CurrentTicket.SeatNumber}";
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
                DialogResult dialogResult = MessageBox.Show(
                    "Bạn có chắc chắn muốn xác nhận đặt vé?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

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

                    // ----- BẮT ĐẦU TẠO MÃ QR -----
                    string departCity = AirportData.Airports.FirstOrDefault(a => a.Code == ticket.DepartCode)?.City ?? ticket.DepartCode;
                    string arriveCity = AirportData.Airports.FirstOrDefault(a => a.Code == ticket.ArriveCode)?.City ?? ticket.ArriveCode;

                    string qrData = $"Tên: {ticket.FullName}\n" +
                                    $"CCCD: {ticket.CCCD}\n" +
                                    $"SĐT: {ticket.PhoneNumber}\n" +
                                    $"Chuyến bay: {ticket.FlightNumber} ({ticket.Airline})\n" +
                                    $"Từ: {departCity} → {arriveCity}\n" +
                                    $"Thời gian: {ticket.DepartureDate:dd/MM/yyyy HH:mm} - {ticket.ArrivalDate:dd/MM/yyyy HH:mm}\n" +
                                    $"Ghế: {ticket.SeatNumber} | Giá: {ticket.Price:N0} VND";


                    using (QRCoder.QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator())
                    using (QRCoder.QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrData, QRCoder.QRCodeGenerator.ECCLevel.Q))
                    using (QRCoder.QRCode qrCode = new QRCoder.QRCode(qrCodeData))
                    {
                        Bitmap qrBitmap = qrCode.GetGraphic(20);

                        int width = 800;
                        int height = 320;
                        Bitmap finalImage = new Bitmap(width, height);

                        using (Graphics g = Graphics.FromImage(finalImage))
                        {
                            g.Clear(Color.White);

                            int qrSize = 250;
                            g.DrawImage(qrBitmap, 30, 30, qrSize, qrSize);

                            Font font = new Font("Arial", 16);
                            Brush brush = Brushes.Black;
                            int xText = 300;
                            int yText = 30;
                            int lineHeight = 40;

                            g.DrawString($"Tên: {ticket.FullName}", font, brush, xText, yText); yText += lineHeight;
                            g.DrawString($"CCCD: {ticket.CCCD}", font, brush, xText, yText); yText += lineHeight;
                            g.DrawString($"SĐT: {ticket.PhoneNumber}", font, brush, xText, yText); yText += lineHeight;
                            g.DrawString($"Chuyến bay: {ticket.FlightNumber} ({ticket.Airline})", font, brush, xText, yText); yText += lineHeight;
                            g.DrawString($"Từ: {departCity} → {arriveCity}", font, brush, xText, yText); yText += lineHeight;
                            g.DrawString($"Thời gian: {ticket.DepartureDate:dd/MM/yyyy HH:mm} - {ticket.ArrivalDate:dd/MM/yyyy HH:mm}", font, brush, xText, yText); yText += lineHeight;
                            g.DrawString($"Ghế: {ticket.SeatNumber} | Giá: {ticket.Price:N0} VND", font, brush, xText, yText);
                        }

                        string path = $"Ticket_QR_{ticket.TicketID}.png";
                        finalImage.Save(path, System.Drawing.Imaging.ImageFormat.Png);
                        QRDisplayForm qrForm = new QRDisplayForm(finalImage);
                        qrForm.StartPosition = FormStartPosition.CenterScreen;
                        qrForm.ShowDialog();
                    }
                    // ----- KẾT THÚC TẠO MÃ QR -----

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
