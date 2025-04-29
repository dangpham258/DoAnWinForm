using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowSkylineProject;
using DataTransferObject;

namespace Presentation
{
    public partial class BookingFlightChooseForm : Form
    {
        private SerpClient serpClient = new SerpClient();

        public BookingFlightChooseForm()
        {
            InitializeComponent();
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin người dùng nhập
                string departureId = cbbDiemdi.Text.Trim();   // "SGN"
                string arrivalId = cbbDiemden.Text.Trim();     // "DAD"
                string outboundDate = flightDatePicker.Value.ToString("yyyy-MM-dd");

                // Gọi API để lấy dữ liệu JSON
                string jsonData = await serpClient.GetGoogleFlightsAsync(
                    departureId,
                    arrivalId,
                    outboundDate,
                    "VND",    // currency
                    "en",     // hl
                    "vn"      // gl
                );

                // Chuyển JSON thành DataTable và hiển thị trực tiếp lên GridView
                DataTable dt = serpClient.GetFlightOffersDataTable(jsonData);
                dataGridViewFlightOffers.DataSource = dt;

                // Tùy chỉnh hiển thị của GridView
                FormatDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tìm chuyến bay: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDataGridView()
        {
            // Cách hiển thị các cột trong GridView
            dataGridViewFlightOffers.Columns["FlightNumber"].HeaderText = "Số hiệu";
            dataGridViewFlightOffers.Columns["Airline"].HeaderText = "Hãng bay";
            dataGridViewFlightOffers.Columns["Price"].HeaderText = "Giá vé";
            dataGridViewFlightOffers.Columns["Currency"].HeaderText = "Tiền tệ";
            dataGridViewFlightOffers.Columns["DepartureAirport"].HeaderText = "Sân bay đi";
            dataGridViewFlightOffers.Columns["ArrivalAirport"].HeaderText = "Sân bay đến";
            dataGridViewFlightOffers.Columns["DepartureTime"].HeaderText = "Giờ khởi hành";
            dataGridViewFlightOffers.Columns["ArrivalTime"].HeaderText = "Giờ đến";
            dataGridViewFlightOffers.Columns["CabinClass"].HeaderText = "Hạng ghế";

            // Định dạng giờ
            dataGridViewFlightOffers.Columns["DepartureTime"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dataGridViewFlightOffers.Columns["ArrivalTime"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

            // Định dạng giá tiền
            dataGridViewFlightOffers.Columns["Price"].DefaultCellStyle.Format = "N0";
            dataGridViewFlightOffers.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PassengerLoginForm next = new PassengerLoginForm();
            next.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            BookingInformationForm next = new BookingInformationForm();
            next.Show();
            this.Hide();
        }
    }
}
