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

        public bool ChangeSeat(string ticketID, string newSeatNumber, string flightNumber, DateTime departureDate, DateTime arrivalDate)
        {
            bool result = false;
            try
            {
                conn.Open();

                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    // 1. Lấy ghế cũ từ vé hiện tại
                    string getCurrentSeatQuery = "SELECT SeatNumber FROM Table_TicketDatabase WHERE TicketID = @TicketID";
                    SqlCommand getCurrentSeatCmd = new SqlCommand(getCurrentSeatQuery, conn, transaction);
                    getCurrentSeatCmd.Parameters.AddWithValue("@TicketID", ticketID);
                    string oldSeatNumber = (string)getCurrentSeatCmd.ExecuteScalar();

                    // 2. Cập nhật ghế mới trong bảng vé
                    string updateTicketQuery = "UPDATE Table_TicketDatabase SET SeatNumber = @NewSeatNumber WHERE TicketID = @TicketID";
                    SqlCommand updateTicketCmd = new SqlCommand(updateTicketQuery, conn, transaction);
                    updateTicketCmd.Parameters.AddWithValue("@NewSeatNumber", newSeatNumber);
                    updateTicketCmd.Parameters.AddWithValue("@TicketID", ticketID);
                    updateTicketCmd.ExecuteNonQuery();

                    // 3. Cập nhật trạng thái ghế trong bảng FlightInfoDatabase
                    // Đánh dấu ghế cũ là trống (0)
                    string updateOldSeatQuery = $"UPDATE Table_FlightInfoDatabase SET {oldSeatNumber} = 0 " +
                                              "WHERE FlightNumber = @FlightNumber AND DepartureDate = @DepartureDate AND ArrivalDate = @ArrivalDate";
                    SqlCommand updateOldSeatCmd = new SqlCommand(updateOldSeatQuery, conn, transaction);
                    updateOldSeatCmd.Parameters.AddWithValue("@FlightNumber", flightNumber);
                    updateOldSeatCmd.Parameters.AddWithValue("@DepartureDate", departureDate);
                    updateOldSeatCmd.Parameters.AddWithValue("@ArrivalDate", arrivalDate);
                    updateOldSeatCmd.ExecuteNonQuery();

                    // Đánh dấu ghế mới là có người (1)
                    string updateNewSeatQuery = $"UPDATE Table_FlightInfoDatabase SET {newSeatNumber} = 1 " +
                                              "WHERE FlightNumber = @FlightNumber AND DepartureDate = @DepartureDate AND ArrivalDate = @ArrivalDate";
                    SqlCommand updateNewSeatCmd = new SqlCommand(updateNewSeatQuery, conn, transaction);
                    updateNewSeatCmd.Parameters.AddWithValue("@FlightNumber", flightNumber);
                    updateNewSeatCmd.Parameters.AddWithValue("@DepartureDate", departureDate);
                    updateNewSeatCmd.Parameters.AddWithValue("@ArrivalDate", arrivalDate);
                    updateNewSeatCmd.ExecuteNonQuery();

                    transaction.Commit();
                    result = true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return result;
        }
    }
}
