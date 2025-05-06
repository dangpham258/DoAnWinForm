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
                                "PilotID = @PilotID, PilotName = @PilotName, " +
                                "CoPilotID = @CoPilotID, CoPilotName = @CoPilotName, " +
                                "AttendantID = @AttendantID, AttendantName = @AttendantName " +
                                "WHERE FlightID = @FlightID";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@PilotID", flight.PilotID.HasValue ? (object)flight.PilotID : DBNull.Value),
                    new SqlParameter("@PilotName", flight.PilotName ?? (object)DBNull.Value),
                    new SqlParameter("@CoPilotID", flight.CoPilotID.HasValue ? (object)flight.CoPilotID : DBNull.Value),
                    new SqlParameter("@CoPilotName", flight.CoPilotName ?? (object)DBNull.Value),
                    new SqlParameter("@AttendantID", flight.AttendantID.HasValue ? (object)flight.AttendantID : DBNull.Value),
                    new SqlParameter("@AttendantName", flight.AttendantName ?? (object)DBNull.Value),
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
                List<SqlParameter> parameters = new List<SqlParameter>();
                List<string> personIDs = new List<string>();

                if (flight.PilotID.HasValue)
                {
                    parameters.Add(new SqlParameter("@PilotID", flight.PilotID.Value));
                    personIDs.Add("@PilotID");
                }
                if (flight.CoPilotID.HasValue)
                {
                    parameters.Add(new SqlParameter("@CoPilotID", flight.CoPilotID.Value));
                    personIDs.Add("@CoPilotID");
                }
                if (flight.AttendantID.HasValue)
                {
                    parameters.Add(new SqlParameter("@AttendantID", flight.AttendantID.Value));
                    personIDs.Add("@AttendantID");
                }
                if (personIDs.Count == 0)
                {
                    return true;
                }

                string sqlStr = "UPDATE Table_CrewDatabase SET Status = 0 WHERE PersonID IN (" +
                                string.Join(", ", personIDs) + ")";

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
