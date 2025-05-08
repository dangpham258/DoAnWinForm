using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class LoadReport
    {
        private readonly Database db = new Database();

        public DataSet LoadReportData(int flightID)
        {
            try
            {
                var ds = new DataSet();

                const string sqlFlight = @"SELECT * FROM Table_FlightInfoDatabase WHERE FlightID = @FlightID";

                var flightParams = new List<SqlParameter> { new SqlParameter("@FlightID", flightID) };
                var dtFlight = db.ExecuteQuery(sqlFlight, flightParams);
                dtFlight.TableName = "FlightInfo";

                if (dtFlight.Rows.Count == 0)
                    throw new DataAccessException($"Không tìm thấy chuyến bay với ID = {flightID}");

                ds.Tables.Add(dtFlight);

                // Lấy giá trị FlightNumber và DepartureDate để dùng cho các truy vấn tiếp theo
                var flightRow = dtFlight.Rows[0];
                string flightNumber = flightRow["FlightNumber"].ToString();
                DateTime departureDate = (DateTime)flightRow["DepartureDate"];

                // Lấy thông tin phi hành đoàn
                var personIds = new List<int>();
                foreach (var col in new[] { "PilotID", "CoPilotID", "AttendantID" })
                {
                    if (flightRow[col] != DBNull.Value)
                        personIds.Add(Convert.ToInt32(flightRow[col]));
                }

                if (personIds.Count > 0)
                {
                    var inParams = new List<string>();
                    var crewParams = new List<SqlParameter>();
                    for (int i = 0; i < personIds.Count; i++)
                    {
                        string name = "@ID" + i;
                        inParams.Add(name);
                        crewParams.Add(new SqlParameter(name, personIds[i]));
                    }

                    string sqlCrew = $@"SELECT * FROM Table_CrewDatabase WHERE PersonID IN ({string.Join(",", inParams)})";

                    var dtCrew = db.ExecuteQuery(sqlCrew, crewParams);
                    dtCrew.TableName = "CrewInfo";
                    ds.Tables.Add(dtCrew);
                }
                else
                {
                    ds.Tables.Add(new DataTable("CrewInfo"));
                }

                // Lấy thông tin hành khách
                const string sqlPass = @"SELECT * FROM Table_TicketDatabase 
                                WHERE FlightNumber = @FlightNumber 
                                AND CONVERT(date, DepartureDate) = @DepartureDate";

                var passParams = new List<SqlParameter>
                {
                new SqlParameter("@FlightNumber", flightNumber),
                new SqlParameter("@DepartureDate", departureDate.Date)
                };
                var dtPass = db.ExecuteQuery(sqlPass, passParams);
                dtPass.TableName = "PassengerInfo";
                ds.Tables.Add(dtPass);

                return ds;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Lỗi khi load dữ liệu báo cáo", ex);
            }
        }
    }
}
