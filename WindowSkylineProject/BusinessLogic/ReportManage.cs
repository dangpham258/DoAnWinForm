using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataTransferObject;

namespace BusinessLogic
{
    public class ReportManage
    {
        private readonly LoadReport loader = new LoadReport();

        public string CheckNullData(FlightInfo flight)
        {
            if (flight == null)
                return "Chuyến bay không tồn tại";
            return "";
        }

        public DataSet GetReportData(FlightInfo flight)
        {
            string check = CheckNullData(flight);
            if (!string.IsNullOrEmpty(check))
                return null;

            try
            {
                return loader.LoadReportData(flight.FlightID);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tải dữ liệu báo cáo: " + ex.Message, ex);
            }
        }
    }
}
