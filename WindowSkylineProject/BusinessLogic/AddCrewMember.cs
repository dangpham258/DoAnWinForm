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
        UpdateFlightInfo update = new UpdateFlightInfo();
        public bool AssignCrewToFlight(FlightInfo flight)
        {
            
            return update.UpdateAfterAssign(flight);
        }

        public bool UpdatePilotStatus(int pilotID)
        {
            return update.UpdatePilotStatus(pilotID, true);
        }

        public bool UpdateCoPilotStatus(int coPilotID)
        {
            return update.UpdateCoPilotStatus(coPilotID, true);
        }

        public bool UpdateAttendantStatus(int attendantID)
        {
            return update.UpdateAttendantStatus(attendantID, true);
        }
    }
}
