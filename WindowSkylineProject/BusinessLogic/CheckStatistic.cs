using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CheckStatistic
    {
        private CheckStatistic_Access access = new CheckStatistic_Access();
        public decimal GetTotalRevenue(bool onlyUsedTickets = false)
        {
            return access.GetTotalRevenue(onlyUsedTickets);
        }

        public Dictionary<string, decimal> GetRevenueByAirline()
        {
            return access.GetRevenueByAirline();
        }

        public int GetTotalPassengers(bool onlyUsedTickets = false)
        {
            return access.GetTotalPassengers(onlyUsedTickets);
        }

        public Dictionary<string, int> GetPassengersByAirline(bool onlyUsedTickets = false)
        {
            return access.GetPassengersByAirline(onlyUsedTickets);
        }

        public Dictionary<int, int> GetFlightsPerDayInCurrentMonth()
        {
            return access.GetFlightsPerDayInCurrentMonth();
        }
    }
}