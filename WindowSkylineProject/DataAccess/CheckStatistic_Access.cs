using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CheckStatistic_Access : Database
    {
        private SqlConnection conn;

        public CheckStatistic_Access()
        {
            conn = base.sqlConn;
        }

        // Lấy tổng doanh thu (tổng giá trị tiền các vé)
        public decimal GetTotalRevenue(bool onlyUsedTickets = false)
        {
            decimal totalRevenue = 0;
            try
            {
                string query = "SELECT SUM(Price) FROM Table_TicketDatabase";
                if (onlyUsedTickets)
                {
                    query += " WHERE Status = 1"; // Chỉ tính vé đã sử dụng
                }

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        totalRevenue = Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy tổng doanh thu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return totalRevenue;
        }

        // Lấy doanh thu theo từng hãng bay (chỉ tính vé đã sử dụng)
        public Dictionary<string, decimal> GetRevenueByAirline()
        {
            Dictionary<string, decimal> airlineRevenue = new Dictionary<string, decimal>();
            try
            {
                string query = "SELECT Airline, SUM(Price) AS TotalRevenue " +
                               "FROM Table_TicketDatabase " +
                               "WHERE Status = 1 " +  // Chỉ tính vé đã sử dụng
                               "GROUP BY Airline " +
                               "ORDER BY TotalRevenue DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string airline = reader["Airline"].ToString();
                            decimal revenue = Convert.ToDecimal(reader["TotalRevenue"]);
                            airlineRevenue.Add(airline, revenue);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy doanh thu theo hãng bay: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return airlineRevenue;
        }

        // Lấy tổng số lượng khách
        public int GetTotalPassengers(bool onlyUsedTickets = false)
        {
            int totalPassengers = 0;
            try
            {
                string query = "SELECT COUNT(*) FROM Table_TicketDatabase";
                if (onlyUsedTickets)
                {
                    query += " WHERE Status = 1"; // Chỉ tính vé đã sử dụng
                }

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        totalPassengers = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy tổng số lượng khách: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return totalPassengers;
        }

        // Lấy số lượng khách theo từng hãng bay
        public Dictionary<string, int> GetPassengersByAirline(bool onlyUsedTickets = false)
        {
            Dictionary<string, int> airlinePassengers = new Dictionary<string, int>();
            try
            {
                string query = "SELECT Airline, COUNT(*) AS PassengerCount " +
                               "FROM Table_TicketDatabase";

                if (onlyUsedTickets)
                {
                    query += " WHERE Status = 1";
                }

                query += " GROUP BY Airline ORDER BY PassengerCount DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string airline = reader["Airline"].ToString();
                            int count = Convert.ToInt32(reader["PassengerCount"]);
                            airlinePassengers.Add(airline, count);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy số lượng khách theo hãng bay: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return airlinePassengers;
        }

        // Lấy số lượng chuyến bay mỗi ngày trong tháng hiện tại
        public Dictionary<int, int> GetFlightsPerDayInCurrentMonth()
        {
            Dictionary<int, int> flightsPerDay = new Dictionary<int, int>();
            try
            {
                // Lấy tháng và năm hiện tại
                DateTime now = DateTime.Now;
                int currentMonth = now.Month;
                int currentYear = now.Year;

                string query = "SELECT DAY(DepartureDate) AS DayOfMonth, COUNT(*) AS FlightCount " +
                               "FROM Table_TicketDatabase " +
                               "WHERE MONTH(DepartureDate) = @Month AND YEAR(DepartureDate) = @Year " +
                               "GROUP BY DAY(DepartureDate) " +
                               "ORDER BY DayOfMonth";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Month", currentMonth);
                    cmd.Parameters.AddWithValue("@Year", currentYear);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int day = Convert.ToInt32(reader["DayOfMonth"]);
                            int flightCount = Convert.ToInt32(reader["FlightCount"]);
                            flightsPerDay.Add(day, flightCount);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy số lượng chuyến bay mỗi ngày: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return flightsPerDay;
        }
    }
}