using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightsManager.DataTransferObjects.Entities.Flights
{
    public class FlightSaveDTO
    {
        public int AirportFrom { get; set; }

        public int AirportTo { get; set; }

        public int Aircraft { get; set; }
    }
}