using FlightsManager.DataTransferObjects.Entities.Aircrafts;
using FlightsManager.DataTransferObjects.Entities.Airports;
using FlightsManager.DataTransferObjects.Entities.Flights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightsManager.Services.Interfaces
{
    public interface IFlightService
    {
        IEnumerable<FlightDTO> GetFlights();

        FlightSaveDTO GetFlight(int flightId);

        void CreateFlight(FlightSaveDTO flightSaveDTO);

        void UpdateFlight(int flightId, FlightSaveDTO flightSaveDTO);

        void DeleteFlight(int flightId);

        IEnumerable<AircraftDTO> GetAircrafts();

        IEnumerable<AirportDTO> GetAirports();
    }
}