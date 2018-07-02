using FlightsManager.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightsManager.Data.Implementations
{
    public class FlightsContext
    {
        private static FlightsContext _instance;

        private FlightsContext()
        {
            this.Flights = new List<Flight>();
        }

        public static FlightsContext Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FlightsContext();
                }

                return _instance;
            }
        }

        public ICollection<Flight> Flights { get; set; }

        public ICollection<Airport> Airports
        {
            get
            {
                return new List<Airport>()
                {
                    new Airport() { Id = 1, Description = "Malaga", Latitude = 36.72, Longitude = -4.420277777777778 },
                    new Airport() { Id = 2, Description = "Madrid", Latitude = 40.41638888888889, Longitude = -3.7025 },
                    new Airport() { Id = 3, Description = "Barcelona", Latitude = 41.38861111111111, Longitude = -2.158888888888889 },
                    new Airport() { Id = 4, Description = "Bilbao", Latitude = 43.263013, Longitude = -2.934985 },
                    new Airport() { Id = 5, Description = "Santiago", Latitude = 342.88027777777778, Longitude = -8.545555555555556 }
                };
            }
        }

        public ICollection<Aircraft> Aircrafts
        {
            get
            {
                return new List<Aircraft>()
                {
                    new Aircraft() { Id = 1, Description = "Boeing AB-721", TakeOffConsumption = 60, KmConsumption = 15 },
                    new Aircraft() { Id = 2, Description = "Boeing CE-453", TakeOffConsumption = 58, KmConsumption = 15 },
                    new Aircraft() { Id = 3, Description = "Boeing RF-567", TakeOffConsumption = 65, KmConsumption = 15 },
                    new Aircraft() { Id = 4, Description = "Boeing ER-083", TakeOffConsumption = 57, KmConsumption = 15 },
                    new Aircraft() { Id = 5, Description = "Boeing RE-340", TakeOffConsumption = 62, KmConsumption = 15 }
                };
            }
        }
    }
}