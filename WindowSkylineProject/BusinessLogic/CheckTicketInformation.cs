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
    }
}
