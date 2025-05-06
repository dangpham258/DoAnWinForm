using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CheckCrewMember : Database
    {
        SqlConnection conn;
        public CheckCrewMember()
        {
            conn = base.sqlConn;
        }
        public DataTable GetCrewMemberInfo(string userName)
        {
            try
            {
                string query = @"
                    SELECT PersonID, UserName, FullName, JobType, YearsOfExperience, 
                           PhoneNumber, CCCD, Status
                    FROM Table_CrewDatabase
                    WHERE UserName = @UserName";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@UserName", userName)
                };

                return ExecuteQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Lỗi khi lấy thông tin phi hành đoàn: ", ex);
            }
        }

        public bool UpdateCrewMemberStatus(string userName, int status)
        {
            try
            {
                string query = @"
                    UPDATE Table_CrewDatabase
                    SET Status = @Status
                    WHERE UserName = @UserName";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@UserName", userName),
                    new SqlParameter("@Status", status)
                };

                int rowsAffected = ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Lỗi khi cập nhật trạng thái phi hành đoàn: ", ex);
            }
        }

        public DataTable GetCurrentFlightInfo(int crewID)
        {
            try
            {
                string query = @"
                SELECT 
                    FlightID, FlightNumber, Airline, 
                    DepartCode, ArriveCode, 
                    DepartureDate, ArrivalDate,
                    PilotID, PilotName, 
                    CoPilotID, CoPilotName, 
                    AttendantID, AttendantName,
                    PassengerCount,
                    G1, G2, G3, G4, G5, G6, G7, G8, G9, G10
                FROM 
                    Table_FlightInfoDatabase
                WHERE 
                    (PilotID = @CrewID OR CoPilotID = @CrewID OR AttendantID = @CrewID)
                    AND DepartureDate > GETDATE()
                ORDER BY 
                    DepartureDate ASC";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@CrewID", crewID)
                };

                return ExecuteQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Lỗi khi lấy thông tin chuyến bay: ", ex);
            }
        }

        public bool HasFlightsInFuture(int id)
        {
            try
            {
                string sqlStr = "SELECT COUNT(*) FROM Table_FlightInfoDatabase " +
                    "WHERE (PilotID = @ID OR CoPilotID = @ID OR AttendantID = @ID) " +
                    "AND CAST(DepartureDate AS DATE) >= CAST(GETDATE() AS DATE)";

                List<SqlParameter> parameters = new List<SqlParameter> {
                    new SqlParameter("@ID", id)
                };

                int count = Convert.ToInt32(ExecuteScalar(sqlStr, parameters));
                return count > 0;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Lỗi khi kiểm tra thông tin chuyến bay trong tương lai: ", ex);
            }
        }
    }
}
