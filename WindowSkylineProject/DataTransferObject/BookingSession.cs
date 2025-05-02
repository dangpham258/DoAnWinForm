using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public static class BookingSession
    {
        // Lưu FlightInfo (chuyến bay)
        public static FlightInfo CurrentFlight { get; set; }

        // Lưu Ticket (vé khách)
        public static Ticket CurrentTicket { get; set; }
    }
}
