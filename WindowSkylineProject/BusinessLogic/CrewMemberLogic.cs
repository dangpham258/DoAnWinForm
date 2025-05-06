using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CrewMemberLogic
    {
        CheckCrewMember crewAccess = new CheckCrewMember();
        public DataTable GetCrewMemberInfo(string userName)
        {
            try
            {
                return crewAccess.GetCrewMemberInfo(userName);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi nghiệp vụ khi lấy thông tin phi hành đoàn: " + ex.Message, ex);
            }
        }

        public bool UpdateCrewMemberStatus(string userName, int status)
        {
            try
            {
                return crewAccess.UpdateCrewMemberStatus(userName, status);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi nghiệp vụ khi cập nhật trạng thái phi hành đoàn: " + ex.Message, ex);
            }
        }

        public DataTable GetCurrentFlightInfo(int crewID)
        {
            try
            {
                return crewAccess.GetCurrentFlightInfo(crewID);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi nghiệp vụ khi lấy thông tin chuyến bay: " + ex.Message, ex);
            }
        }
        public bool IsBusyInFuture(int id)
        {
            return crewAccess.HasFlightsInFuture(id);
        }
    }
}
