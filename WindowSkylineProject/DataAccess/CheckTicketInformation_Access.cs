using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace DataAccess
{
    public class CheckTicketInformation_Access : Database
    {
        SqlConnection conn;
        public CheckTicketInformation_Access()
        {
            conn = base.sqlConn;
        }

        public bool AddTicket(Ticket ticket)
        {
            try
            {
                string query = @"
                    INSERT INTO Table_TicketDatabase (
                        FullName, PhoneNumber, CCCD, DepartCode, ArriveCode,
                        FlightNumber, Airline, DepartureDate, ArrivalDate,
                        ClassType, SeatNumber, Price
                    ) VALUES (
                        @FullName, @PhoneNumber, @CCCD, @DepartCode, @ArriveCode,
                        @FlightNumber, @Airline, @DepartureDate, @ArrivalDate,
                        @ClassType, @SeatNumber, @Price
                    )";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@FullName", ticket.FullName),
                    new SqlParameter("@PhoneNumber", ticket.PhoneNumber),
                    new SqlParameter("@CCCD", ticket.CCCD),
                    new SqlParameter("@DepartCode", ticket.DepartCode),
                    new SqlParameter("@ArriveCode", ticket.ArriveCode),
                    new SqlParameter("@FlightNumber", ticket.FlightNumber),
                    new SqlParameter("@Airline", ticket.Airline),
                    new SqlParameter("@DepartureDate", ticket.DepartureDate),
                    new SqlParameter("@ArrivalDate", ticket.ArrivalDate),
                    new SqlParameter("@ClassType", ticket.ClassType),
                    new SqlParameter("@SeatNumber", ticket.SeatNumber),
                    new SqlParameter("@Price", ticket.Price)
                };

                int rowsAffected = ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Lỗi thêm vé máy bay: ", ex);
            }
        }

        public bool AddFlightInfo(FlightInfo flightInfo, string seatNumber = null)
        {
            try
            {
                // Trước tiên, kiểm tra xem chuyến bay đã tồn tại chưa để cập nhật PassengerCount và đánh dấu ghế
                string checkQuery = $@"
            SELECT * FROM Table_FlightInfoDatabase 
            WHERE FlightNumber = '{flightInfo.FlightNumber}' AND 
                  DepartureDate = '{flightInfo.DepartureDate.ToString("yyyy-MM-dd HH:mm:ss")}' AND 
                  ArrivalDate = '{flightInfo.ArrivalDate.ToString("yyyy-MM-dd HH:mm:ss")}'";

                // Lấy thông tin chuyến bay nếu đã tồn tại
                var flightData = ExecuteQuery(checkQuery);

                if (flightData != null && flightData.Rows.Count > 0)
                {
                    // Chuyến bay đã tồn tại, cập nhật PassengerCount và đánh dấu ghế
                    DataRow existingFlight = flightData.Rows[0];
                    int currentPassengerCount = Convert.ToInt32(existingFlight["PassengerCount"]);

                    // Tạo câu lệnh UPDATE với các trường cần cập nhật
                    string updateQuery = $@"
                UPDATE Table_FlightInfoDatabase SET 
                PassengerCount = {currentPassengerCount + 1}";

                    // Nếu có số ghế được đặt, cập nhật trạng thái ghế
                    if (!string.IsNullOrEmpty(seatNumber))
                    {
                        // Số ghế có định dạng "G1", "G2", ...
                        // Trích xuất số từ seatNumber (bỏ ký tự G đầu tiên)
                        if (seatNumber.StartsWith("G") && seatNumber.Length > 1)
                        {
                            int seatIndex;
                            if (int.TryParse(seatNumber.Substring(1), out seatIndex) && seatIndex >= 1 && seatIndex <= 10)
                            {
                                updateQuery += $", G{seatIndex} = 1";
                            }
                        }
                    }

                    updateQuery += $@" WHERE FlightNumber = '{flightInfo.FlightNumber}' 
                              AND DepartureDate = '{flightInfo.DepartureDate.ToString("yyyy-MM-dd HH:mm:ss")}' 
                              AND ArrivalDate = '{flightInfo.ArrivalDate.ToString("yyyy-MM-dd HH:mm:ss")}'";

                    int rowsAffected = ExecuteNonQuery(updateQuery);
                    return rowsAffected > 0;
                }
                else
                {
                    // Chuyến bay chưa tồn tại, thêm mới
                    // Khởi tạo tất cả ghế là 0 (trống)
                    int g1 = 0, g2 = 0, g3 = 0, g4 = 0, g5 = 0, g6 = 0, g7 = 0, g8 = 0, g9 = 0, g10 = 0;

                    // Đánh dấu ghế đã chọn là 1 (đã đặt)
                    if (!string.IsNullOrEmpty(seatNumber))
                    {
                        if (seatNumber.StartsWith("G") && seatNumber.Length > 1)
                        {
                            int seatIndex;
                            if (int.TryParse(seatNumber.Substring(1), out seatIndex))
                            {
                                switch (seatIndex)
                                {
                                    case 1: g1 = 1; break;
                                    case 2: g2 = 1; break;
                                    case 3: g3 = 1; break;
                                    case 4: g4 = 1; break;
                                    case 5: g5 = 1; break;
                                    case 6: g6 = 1; break;
                                    case 7: g7 = 1; break;
                                    case 8: g8 = 1; break;
                                    case 9: g9 = 1; break;
                                    case 10: g10 = 1; break;
                                }
                            }
                        }
                    }

                    string insertQuery = $@"
                INSERT INTO Table_FlightInfoDatabase (
                    FlightNumber, Airline, DepartCode, ArriveCode, DepartureDate, ArrivalDate,
                    PilotID, PilotName, CoPilotID, CoPilotName, AttendantID, AttendantName, PassengerCount,
                    G1, G2, G3, G4, G5, G6, G7, G8, G9, G10
                ) VALUES (
                    '{flightInfo.FlightNumber}', 
                    '{flightInfo.Airline}', 
                    '{flightInfo.DepartCode}', 
                    '{flightInfo.ArriveCode}', 
                    '{flightInfo.DepartureDate.ToString("yyyy-MM-dd HH:mm:ss")}', 
                    '{flightInfo.ArrivalDate.ToString("yyyy-MM-dd HH:mm:ss")}',
                    {(flightInfo.PilotID.HasValue ? flightInfo.PilotID.ToString() : "NULL")}, 
                    {(string.IsNullOrEmpty(flightInfo.PilotName) ? "NULL" : $"'{flightInfo.PilotName}'")}, 
                    {(flightInfo.CoPilotID.HasValue ? flightInfo.CoPilotID.ToString() : "NULL")}, 
                    {(string.IsNullOrEmpty(flightInfo.CoPilotName) ? "NULL" : $"'{flightInfo.CoPilotName}'")}, 
                    {(flightInfo.AttendantID.HasValue ? flightInfo.AttendantID.ToString() : "NULL")}, 
                    {(string.IsNullOrEmpty(flightInfo.AttendantName) ? "NULL" : $"'{flightInfo.AttendantName}'")}, 
                    1, 
                    {g1}, {g2}, {g3}, {g4}, {g5}, {g6}, {g7}, {g8}, {g9}, {g10}
                )";

                    int rowsAffected = ExecuteNonQuery(insertQuery);
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Lỗi thêm thông tin chuyến bay: ", ex);
            }
        }

    }
}
