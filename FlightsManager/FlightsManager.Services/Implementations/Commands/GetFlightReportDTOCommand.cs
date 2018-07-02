using FlightsManager.DataTransferObjects.Reports.Flights;
using FlightsManager.Model.Entities;
using FlightsManager.Services.Interfaces.Commands;
using System.Device.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightsManager.Services.Implementations.Commands
{
    public class GetFlightReportDTOCommand : IGetFlightReportDTOCommand
    {
        public FlightReportDTO Execute(Flight flight)
        {
            var fromCoordinate = new GeoCoordinate(flight.From.Latitude, flight.From.Longitude);
            var toCoordinate = new GeoCoordinate(flight.To.Latitude, flight.To.Longitude);

            var distanceKms = fromCoordinate.GetDistanceTo(toCoordinate) / 1000;

            var fuel = flight.Aircraft.TakeOffConsumption + (flight.Aircraft.KmConsumption * distanceKms);

            return new FlightReportDTO()
            {
                From = flight.From.Description,
                To = flight.To.Description,
                Distance = Math.Round(distanceKms, 2, MidpointRounding.AwayFromZero),
                Aircraft = flight.Aircraft.Description,
                Fuel = Math.Round(fuel, 2, MidpointRounding.AwayFromZero),
            };
        }
    }
}