using DataAccess;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class AddCrewMember
    {
        public bool AssignCrewToFlight(FlightInfo flight)
        {
            UpdateFlightInfo update = new UpdateFlightInfo();
            return update.UpdateAfterAssign(flight);
        }
    }
}
