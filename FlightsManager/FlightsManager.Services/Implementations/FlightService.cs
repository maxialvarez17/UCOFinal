using FlightsManager.DataTransferObjects.Entities.Aircrafts;
using FlightsManager.DataTransferObjects.Entities.Airports;
using FlightsManager.DataTransferObjects.Entities.Flights;
using FlightsManager.Model.Entities;
using FlightsManager.Data.Implementations.Repositories;
using FlightsManager.Data.Interfaces.Repositories;
using FlightsManager.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightsManager.Services.Implementations
{
    public class FlightService : IFlightService
    {
        private readonly IRepository<Flight> flightRepository;
        private readonly IReadOnlyRepository<Airport> airportRepository;
        private readonly IReadOnlyRepository<Aircraft> aircraftRepository;

        public FlightService()
        {
            this.flightRepository = new FlightRepository();
            this.airportRepository = new AirportRepository();
            this.aircraftRepository = new AircraftRepository();
        }

        public FlightSaveDTO GetFlight(int flightId)
        {
            var flight = this.flightRepository.Get(flightId);

            return new FlightSaveDTO()
            {
                AirportFrom = flight.From.Id,
                AirportTo = flight.To.Id,
                Aircraft = flight.Aircraft.Id
            };
        }

        public void CreateFlight(FlightSaveDTO flightSaveDTO)
        {
            var flight = new Flight()
            {
                From = this.airportRepository.Get(flightSaveDTO.AirportFrom),
                To = this.airportRepository.Get(flightSaveDTO.AirportTo),
                Aircraft = this.aircraftRepository.Get(flightSaveDTO.Aircraft)
            };

            this.flightRepository.Insert(flight);
        }

        public void UpdateFlight(int flightId, FlightSaveDTO flightSaveDTO)
        {
            var flight = new Flight()
            {
                Id = flightId,
                From = this.airportRepository.Get(flightSaveDTO.AirportFrom),
                To = this.airportRepository.Get(flightSaveDTO.AirportTo),
                Aircraft = this.aircraftRepository.Get(flightSaveDTO.Aircraft)
            };

            this.flightRepository.Update(flight);
        }

        public void DeleteFlight(int flightId)
        {
            this.flightRepository.Delete(flightId);
        }

        public IEnumerable<FlightDTO> GetFlights()
        {
            return this.flightRepository.GetAll()
                .Select(x => new FlightDTO()
                {
                    Id = x.Id,
                    AirportFrom = x.From.Description,
                    AirportTo = x.To.Description,
                    Aircraft = x.Aircraft.Description
                });
        }

        public IEnumerable<AircraftDTO> GetAircrafts()
        {
            return this.aircraftRepository.GetAll()
                .Select(x => new AircraftDTO()
                {
                    Id = x.Id,
                    Description = x.Description
                });
        }

        public IEnumerable<AirportDTO> GetAirports()
        {
            return this.airportRepository.GetAll()
                .Select(x => new AirportDTO()
                {
                    Id = x.Id,
                    Description = x.Description
                });
        }
    }
}