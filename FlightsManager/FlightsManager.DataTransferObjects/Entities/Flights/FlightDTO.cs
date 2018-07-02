using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightsManager.DataTransferObjects.Entities.Flights
{
    public class FlightDTO
    {
        public int Id { get; set; }

        public string AirportFrom { get; set; }

        public string AirportTo { get; set; }

        public string Aircraft { get; set; }
    }
}