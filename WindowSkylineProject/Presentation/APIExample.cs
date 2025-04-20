using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class APIExampleForm : Form
    {
        public APIExampleForm()
        {
            InitializeComponent();
        }

        private void APIExampleForm_Load(object sender, EventArgs e)
        {
            //db = new Database();
            //try
            //{
            //    LoadFlightOffers();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Có lỗi xảy ra khi lấy Flight Offers: " + ex.Message);
            //}
        }

        private void LoadFlightOffers()
        {
            //string sql = @"
            //    SELECT FlightNumber, Airline, Price, Currency, 
            //           DepartureTime, ArrivalTime
            //    FROM FlightOffers
            //    ORDER BY Price ASC";

            //DataTable dt = db.ExecuteQuery(sql);
            //dataGridViewFlightOffers.DataSource = dt;
        }

        private async void btnGetFlights_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    // Lấy thông tin người dùng nhập
            //    string departureId = txtDepart.Text.Trim();   // "SGN"
            //    string arrivalId = txtArrive.Text.Trim();     // "DAD"

            //    string outboundDate = dateOutbound.Value.ToString("yyyy-MM-dd");

            //    // Kiểm tra RadioButton
            //    bool isOneWay = rdbOneWay.Checked;
            //    string returnDate = null;
            //    if (!isOneWay)
            //    {
            //        // Round trip => lấy ngày về
            //        returnDate = dateReturn.Value.ToString("yyyy-MM-dd");
            //    }

            //    // Gọi hàm GetGoogleFlightsAsync của SerpClient, để API lấy json
            //    string jsonData = await serpClient.GetGoogleFlightsAsync(
            //        departureId,
            //        arrivalId,
            //        outboundDate,
            //        "VND",    // currency
            //        "en",     // hl
            //        "vn",     // gl
            //        isOneWay, // chuyến 1 chiều hay khứ hồi
            //        returnDate
            //    );

            //    // Chuyển json Lưu vào DB
            //    serpClient.SaveFlightOffersToDB(jsonData);


            //    // Cách mới của cô ######################################################################################
            //    // Sử dụng hàm ExecuteQuery của lớp Database để lấy dữ liệu và hiển thị vào DataGridView
            //    string sql = @"
            //            SELECT FlightNumber, Airline, Price, Currency, 
            //                   DepartureTime, ArrivalTime
            //            FROM FlightOffers
            //            ORDER BY Price ASC";
            //    ////   DepartureAirport, ArrivalAirport, 

            //    DataTable dt = db.ExecuteQuery(sql);
            //    dataGridViewFlightOffers.DataSource = dt;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Có lỗi xảy ra khi nhấn nút Get Flight: " + ex.Message);
            //}
        }
    }
}
