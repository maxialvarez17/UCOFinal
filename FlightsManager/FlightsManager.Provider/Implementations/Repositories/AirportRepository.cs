using FlightsManager.Model.Entities;
using FlightsManager.Data.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightsManager.Data.Implementations.Repositories
{
    public class AirportRepository : IReadOnlyRepository<Airport>
    {
        private readonly FlightsContext flightsContext;

        public AirportRepository()
        {
            this.flightsContext = FlightsContext.Instance;
        }

        public Airport Get(int id)
        {
            return this.GetAll()
                .Where(x => x.Id.Equals(id))
                .FirstOrDefault();
        }

        public ICollection<Airport> GetAll()
        {
            return this.flightsContext.Airports;
        }
    }
}