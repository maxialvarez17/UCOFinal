using FlightsManager.Model.Entities;
using FlightsManager.Data.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightsManager.Data.Implementations.Repositories
{
    public class FlightRepository : IRepository<Flight>
    {
        private readonly FlightsContext flightsContext;

        public FlightRepository()
        {
            this.flightsContext = FlightsContext.Instance;
        }

        public void Delete(int id)
        {
            var flight = this.Get(id);

            this.flightsContext.Flights.Remove(flight);
        }

        public Flight Get(int id)
        {
            return this.GetAll()
                .Where(x => x.Id.Equals(id))
                .FirstOrDefault();
        }

        public ICollection<Flight> GetAll()
        {
            return this.flightsContext.Flights.OrderBy(x => x.Id).ToList();
        }

        public void Insert(Flight entity)
        {
            entity.Id = this.flightsContext.Flights.Count + 1;

            this.flightsContext.Flights.Add(entity);
        }

        public void Update(Flight entity)
        {
            var flightToUpdate = this.Get(entity.Id);

            this.flightsContext.Flights.Remove(flightToUpdate);
            this.flightsContext.Flights.Add(entity);
        }
    }
}