using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightsManager.Model.Entities
{
    public class Flight
    {
        public int Id { get; set; }

        public Airport To { get; set; }

        public Airport From { get; set; }

        public Aircraft Aircraft { get; set; }
    }
}