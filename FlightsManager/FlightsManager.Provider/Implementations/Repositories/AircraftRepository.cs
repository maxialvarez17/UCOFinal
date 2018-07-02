using FlightsManager.Model.Entities;
using FlightsManager.Data.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightsManager.Data.Implementations.Repositories
{
    public class AircraftRepository : IReadOnlyRepository<Aircraft>
    {
        private readonly FlightsContext flightsContext;

        public AircraftRepository()
        {
            this.flightsContext = FlightsContext.Instance;
        }

        public Aircraft Get(int id)
        {
            return this.GetAll()
                .Where(x => x.Id.Equals(id))
                .FirstOrDefault();
        }

        public ICollection<Aircraft> GetAll()
        {
            return this.flightsContext.Aircrafts;
        }
    }
}