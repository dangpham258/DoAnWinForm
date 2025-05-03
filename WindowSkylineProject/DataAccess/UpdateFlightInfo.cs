using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace DataAccess
{
    public class UpdateFlightInfo
    {
        Database db = new Database();

        public bool UpdateAfterAssign(FlightInfo flight)
        {
            return UpdateFlightInfoTable(flight) && UpdateCrewTable(flight);
        }

        public bool UpdateFlightInfoTable(FlightInfo flight)
        {
            try
            {
                string sqlStr = "UPDATE Table_FlightInfoDatabase SET " +
                        "PilotID = @PilotID, PilotName = @PilotName, CoPilotID = @CoPilotID, CoPilotName = @CoPilotName, " +
                        "AttendantID = @AttendantID, AttendantName = @AttendantName " +
                        "WHERE FlightID = @FlightID";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                new SqlParameter("@PilotID", flight.PilotID),
                new SqlParameter("@PilotName", flight.PilotName),
                new SqlParameter("@CoPilotID", flight.CoPilotID),
                new SqlParameter("@CoPilotName", flight.CoPilotName),
                new SqlParameter("@AttendantID", flight.AttendantID),
                new SqlParameter("@AttendantName", flight.AttendantName),
                new SqlParameter("@FlightID", flight.FlightID)
                };
                return db.ExecuteNonQuery(sqlStr, parameters) > 0;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Lỗi khi cập nhật thông tin chuyến bay", ex);
            }
        }

        public bool UpdateCrewTable(FlightInfo flight)
        {
            try
            {
                string sqlStr = "UPDATE Table_CrewDatabase SET Status = 0 " +
                    "WHERE PersonID IN (@PilotID, @CoPilotID, @AttendantID)";
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                new SqlParameter("@PilotID", flight.PilotID),
                new SqlParameter("@CoPilotID", flight.CoPilotID),
                new SqlParameter("@AttendantID", flight.AttendantID)
                };
                return db.ExecuteNonQuery(sqlStr, parameters) > 0;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Lỗi khi cập nhật thông tin phi hành đoàn", ex);
            }
        }

        public bool UpdatePilotStatus(int pilotId, bool status)
        {
            try
            {
                string sqlStr = "UPDATE Table_CrewDatabase SET Status = @Status WHERE PersonID = @PilotID";
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@Status", status ? 1 : 0),
                    new SqlParameter("@PilotID", pilotId)
                };
                return db.ExecuteNonQuery(sqlStr, parameters) > 0;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Lỗi khi cập nhật trạng thái phi công", ex);
            }
        }

        public bool UpdateCoPilotStatus(int coPilotId, bool status)
        {
            try
            {
                string sqlStr = "UPDATE Table_CrewDatabase SET Status = @Status WHERE PersonID = @CoPilotID";
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@Status", status ? 1 : 0),
                    new SqlParameter("@CoPilotID", coPilotId)
                };
                return db.ExecuteNonQuery(sqlStr, parameters) > 0;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Lỗi khi cập nhật trạng thái cơ phó", ex);
            }
        }

        public bool UpdateAttendantStatus(int attendantId, bool status)
        {
            try
            {
                string sqlStr = "UPDATE Table_CrewDatabase SET Status = @Status WHERE PersonID = @AttendantID";
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@Status", status ? 1 : 0),
                    new SqlParameter("@AttendantID", attendantId)
                };
                return db.ExecuteNonQuery(sqlStr, parameters) > 0;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Lỗi khi cập nhật trạng thái tiếp viên", ex);
            }
        }
    }
}
