using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightsManager.Model.Entities
{
    public class Airport
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}