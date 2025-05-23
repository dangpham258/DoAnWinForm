﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class CheckForLoadToDGV
    {
        GetDataForDGV load = new GetDataForDGV();
        public DataTable ForChoosingFlight()
        {
            return load.GetFlightsPrioritizeWithoutCrew();
        }
        public DataTable ForChoosingPilot()
        {
            return load.GetAvailablePilot();
        }
        public DataTable ForChoosingCoPilot()
        {
            return load.GetAvailableCoPlilot();
        }
        public DataTable ForChoosingAttendant()
        {
            return load.GetAvailableAttendant();
        }
        public DataTable ForCheckFeedback()
        {
            return load.GetFeedbackNotSeen();
        }
        public DataTable ForFeedbackWithFilter(string type, bool seen)
        {
            if (seen) // Đã xem
                return load.GetFeedbackWithFilter(type, 1);

            return load.GetFeedbackWithFilter(type, 0);
        }

        // Load vào form ReportFlight: check = 0 -- lấy hết
        public DataTable ForReportFlight(bool getAll, int? flightID = null, DateTime? dptDate = null)
        {
            if (getAll)
                return load.GetAllFlight();

            return load.GetBaseOnFlightIDorDate(flightID, dptDate);
        }
    }
}
