using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CheckSeat
    {
        private CheckSeat_Access access = new CheckSeat_Access();

        public Dictionary<string, bool> GetSeatStatus(string flightNumber, DateTime departureDate, DateTime arrivalDate)
        {
            return access.GetSeatStatus(flightNumber, departureDate, arrivalDate);
        }
    }
}
