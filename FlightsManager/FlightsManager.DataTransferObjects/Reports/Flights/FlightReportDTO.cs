using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightsManager.DataTransferObjects.Reports.Flights
{
    public class FlightReportDTO
    {
        public string From { get; set; }

        public string To { get; set; }

        public string Aircraft { get; set; }

        public double Distance { get; set; }

        public double Fuel { get; set; }
    }
}