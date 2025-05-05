using DataAccess;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CheckTicketInformation
    {
        public bool UpdateExpiredTickets()
        {
            try
            {
                CheckTicketInformation_Access ticketAccess = new CheckTicketInformation_Access();
                return ticketAccess.UpdateExpiredTickets();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi nghiệp vụ khi cập nhật vé quá hạn: " + ex.Message, ex);
            }
        }

        public bool SaveTicket(Ticket ticket)
        {
            try
            {
                CheckTicketInformation_Access ticketAccess = new CheckTicketInformation_Access();
                return ticketAccess.AddTicket(ticket);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi nghiệp vụ khi lưu vé máy bay: " + ex.Message, ex);
            }
        }

        public bool SaveFlight(FlightInfo flight, string seatNumber = null)
        {
            try
            {
                // Nếu seatNumber là null, thử lấy từ BookingSession
                if (seatNumber == null && BookingSession.CurrentTicket != null)
                {
                    seatNumber = BookingSession.CurrentTicket.SeatNumber;
                }

                CheckTicketInformation_Access flightAccess = new CheckTicketInformation_Access();
                return flightAccess.AddFlightInfo(flight, seatNumber);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi nghiệp vụ khi lưu thông tin máy bay: " + ex.Message, ex);
            }
        }

        public DataTable GetCurrentNotUseTicket(string username)
        {
            try
            {
                CheckTicketInformation_Access ticketAccess = new CheckTicketInformation_Access();
                return ticketAccess.GetCurrentTickets(username);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi nghiệp vụ khi lấy vé chưa sử dụng: " + ex.Message, ex);
            }
        }

        public bool CancelTicket(string ticketID)
        {
            try
            {
                CheckTicketInformation_Access ticketAccess = new CheckTicketInformation_Access();
                return ticketAccess.CancelTicket(ticketID);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi nghiệp vụ khi hủy vé: " + ex.Message, ex);
            }
        }

        public DataTable GetTicketHistory(string userName, string name = null, string departCode = null, string arriveCode = null,
                                         string airline = null, string date = null)
        {
            try
            {
                CheckTicketInformation_Access ticketAccess = new CheckTicketInformation_Access();
                return ticketAccess.GetTicketHistory(userName, name, departCode, arriveCode, airline, date);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi nghiệp vụ khi tìm kiếm lịch sử vé: " + ex.Message, ex);
            }
        }

        public bool UpdatePassengerInfo(string ticketID, string fullName, string phoneNumber, string cccd)
        {
            try
            {
                var access = new CheckTicketInformation_Access();
                return access.UpdatePassengerInfo(ticketID, fullName, phoneNumber, cccd);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi nghiệp vụ khi thay đổi thông tin hành khách: " + ex.Message, ex);
            }
        }
    }
}
