using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Data;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Xml.Linq;

namespace WindowSkylineProject
{
    public class SerpClient
    {
        // Serp API này giới hạn 100 lần mỗi tháng, lên web login tạo tài khoản lấy API 
        private static string serpApiKey = "80674a63504d81062e0cfc34693f97c74af25b21bda76bd9dc39b54d1f2203a5";

        public async Task<string> GetGoogleFlightsAsync(
            string departureId,
            string arrivalId,
            string outboundDate,
            string currency = "VND",
            string hl = "en",
            string gl = "vn")
        {
            string url = "https://serpapi.com/search"
                       + "?api_key=" + serpApiKey
                       + "&engine=google_flights"
                       + "&hl=" + hl
                       + "&gl=" + gl
                       + "&departure_id=" + departureId
                       + "&arrival_id=" + arrivalId
                       + "&outbound_date=" + outboundDate
                       + "&currency=" + currency
                       + "&type=2"; // Luôn chọn one-way

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                // Ném lỗi nếu mã trả về != 2xx
                response.EnsureSuccessStatusCode();

                string jsonData = await response.Content.ReadAsStringAsync();
                return jsonData;
            }
        }

        public DataTable GetFlightOffersDataTable(string jsonData)
        {
            // Tạo DataTable để lưu thông tin chuyến bay
            DataTable dt = new DataTable();
            dt.Columns.Add("FlightNumber", typeof(string));
            dt.Columns.Add("Airline", typeof(string));
            dt.Columns.Add("Price", typeof(int));
            dt.Columns.Add("Currency", typeof(string));
            dt.Columns.Add("DepartureAirport", typeof(string));
            dt.Columns.Add("ArrivalAirport", typeof(string));
            dt.Columns.Add("DepartureTime", typeof(DateTime));
            dt.Columns.Add("ArrivalTime", typeof(DateTime));
            dt.Columns.Add("CabinClass", typeof(string));

            // 1. Parse chuỗi JSON
            JObject root = JObject.Parse(jsonData);

            // 2. Lấy currency (VD: "VND") từ search_parameters
            string currency = root["search_parameters"]?["currency"]?.ToString() ?? "VND";

            // 3. Lấy mảng "best_flights" và "other_flights"
            JArray bestFlights = (JArray)root["best_flights"];
            JArray otherFlights = (JArray)root["other_flights"];

            // Dùng chung 1 list để dễ duyệt
            List<JToken> allFlightsBlocks = new List<JToken>();
            if (bestFlights != null) allFlightsBlocks.AddRange(bestFlights);
            if (otherFlights != null) allFlightsBlocks.AddRange(otherFlights);

            // 4. Duyệt qua từng block của chuyến bay
            foreach (var flightBlock in allFlightsBlocks)
            {
                // Lấy giá vé
                int price = 0;
                int.TryParse(flightBlock["price"]?.ToString(), out price);

                // Duyệt mảng các chuyến bay trong block
                JArray flightsArr = (JArray)flightBlock["flights"];
                if (flightsArr == null) continue;

                foreach (var flight in flightsArr)
                {
                    // Lấy thông tin chuyến bay
                    string flightNumber = flight["flight_number"]?.ToString();
                    string airline = flight["airline"]?.ToString();
                    string departureAirport = flight["departure_airport"]?["id"]?.ToString();
                    string depTimeStr = flight["departure_airport"]?["time"]?.ToString();
                    string arrivalAirport = flight["arrival_airport"]?["id"]?.ToString();
                    string arrTimeStr = flight["arrival_airport"]?["time"]?.ToString();

                    // Lấy thông tin hạng ghế (cabin class)
                    string cabinClass = flight["travel_class"]?.ToString() ?? "Economy"; // Mặc định là Economy nếu không có

                    DateTime departureTime = DateTime.Now;
                    DateTime arrivalTime = DateTime.Now;
                    DateTime.TryParse(depTimeStr, out departureTime);
                    DateTime.TryParse(arrTimeStr, out arrivalTime);

                    // Thêm dữ liệu vào DataTable
                    dt.Rows.Add(
                        flightNumber ?? "",
                        airline ?? "",
                        price,
                        currency,
                        departureAirport ?? "",
                        arrivalAirport ?? "",
                        departureTime,
                        arrivalTime,
                        cabinClass
                    );
                }
            }

            return dt;
        }
    }
}