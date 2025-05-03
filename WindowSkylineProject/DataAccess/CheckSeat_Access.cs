using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CheckSeat_Access : Database
    {
        private SqlConnection conn;

        public CheckSeat_Access()
        {
            conn = base.sqlConn;
        }

        public Dictionary<string, bool> GetSeatStatus(string flightNumber, DateTime departureDate, DateTime arrivalDate)
        {
            Dictionary<string, bool> seatStatus = new Dictionary<string, bool>();
            string query = $@"
            SELECT G1, G2, G3, G4, G5, G6, G7, G8, G9, G10
            FROM Table_FlightInfoDatabase
            WHERE FlightNumber = @FlightNumber AND 
                  DepartureDate = @DepartureDate AND 
                  ArrivalDate = @ArrivalDate";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@FlightNumber", flightNumber);
            cmd.Parameters.AddWithValue("@DepartureDate", departureDate);
            cmd.Parameters.AddWithValue("@ArrivalDate", arrivalDate);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                for (int i = 1; i <= 10; i++)
                {
                    string seatKey = $"G{i}";
                    seatStatus[seatKey] = reader.GetBoolean(i - 1); // 0-based index
                }
            }
            conn.Close();
            return seatStatus;
        }
    }
}
