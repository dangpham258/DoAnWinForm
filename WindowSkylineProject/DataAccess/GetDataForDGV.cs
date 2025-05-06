using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class GetDataForDGV
    {
        Database db = new Database();
        public DataTable GetFlightsPrioritizeWithoutCrew()
        {
            try
            {
                string sqlStr = @"
                SELECT *
                FROM Table_FlightInfoDatabase
                WHERE CAST(DepartureDate AS DATE) >= CAST(GETDATE() AS DATE)
                ORDER BY 
                    CASE 
                        WHEN PilotID   IS NULL 
                          OR CoPilotID IS NULL 
                          OR AttendantID IS NULL 
                        THEN 0 
                        ELSE 1 
                    END,
                    DepartureDate ASC";

                return db.ExecuteQuery(sqlStr);
            }
            catch (Exception ex)
            {
                throw new DataAccessException(
                    "Lỗi khi lấy dữ liệu chuyến bay từ hôm nay trở đi (ưu tiên thiếu phi hành đoàn)",
                    ex);
            }
        }

        public DataTable GetAvailablePilot()
        {
            try
            {
                string sqlStr = "SELECT * FROM Table_CrewDatabase " +
                                "WHERE JobType = 'Pilot' AND Status = 1 " +
                                "ORDER BY YearsOfExperience DESC";
                return db.ExecuteQuery(sqlStr);
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Lỗi khi lấy dữ liệu phi công", ex);
            }
        }

        public DataTable GetAvailableCoPlilot()
        {
            try
            {
                string sqlStr = "SELECT * FROM Table_CrewDatabase " +
                                "WHERE JobType = 'Co-Pilot' AND Status = 1 " +
                                "ORDER BY YearsOfExperience DESC";
                return db.ExecuteQuery(sqlStr);
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Lỗi khi lấy dữ liệu cơ phó", ex);
            }
        }

        public DataTable GetAvailableAttendant()
        {
            try
            {
                string sqlStr = "SELECT * FROM Table_CrewDatabase " +
                                "WHERE JobType = 'Attendant' AND Status = 1 " +
                                "ORDER BY YearsOfExperience DESC";
                return db.ExecuteQuery(sqlStr);
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Lỗi khi lấy dữ liệu tiếp viên", ex);
            }
        }

        public DataTable GetAllFlight()
        {
            try
            {
                string sqlStr = "SELECT * FROM Table_FlightInfoDatabase";
                return db.ExecuteQuery(sqlStr);
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Lỗi khi lấy dữ liệu chuyến bay", ex);
            }
        }

        public DataTable GetBaseOnFlightIDorDate(int? flightID, DateTime? dptDate)
        {
            try
            {
                string sqlStr = "SELECT * FROM Table_FlightInfoDatabase WHERE 1=1";
                List<SqlParameter> parameters = new List<SqlParameter>();

                if (flightID != null)
                {
                    sqlStr += " AND FlightID = @FlightID";
                    parameters.Add(new SqlParameter("@FlightID", flightID));
                }

                if (dptDate != null)
                {
                    sqlStr += " AND CAST(DepartureDate AS DATE) = @FlightDate";
                    parameters.Add(new SqlParameter("@FlightDate", dptDate.Value.Date));
                }

                return db.ExecuteQuery(sqlStr, parameters);
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Lỗi khi lấy dữ liệu chuyến bay theo ID hoặc ngày", ex);
            }
        }

        public DataTable GetFeedbackNotSeen()
        {
            try
            {
                string sqlStr = "SELECT * FROM Table_FeedbackDatabase WHERE Status = 0";
                return db.ExecuteQuery(sqlStr);
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Lỗi khi lấy dữ liệu phản hồi", ex);
            }
        }

        public DataTable GetFeedbackWithFilter(string type, byte status)
        {
            try
            {
                string sqlStr = "SELECT * FROM Table_FeedbackDatabase WHERE Type = @Type AND Status = @Status";
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@Type", type),
                    new SqlParameter("@Status", status)
                };
                return db.ExecuteQuery(sqlStr, parameters);
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Lỗi khi lấy dữ liệu phản hồi với bộ lọc", ex);
            }
        }
    }
}
