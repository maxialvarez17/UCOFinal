using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightsManager.Model.Entities
{
    public class Aircraft
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public double TakeOffConsumption { get; set; }

        public double KmConsumption { get; set; }
    }
}