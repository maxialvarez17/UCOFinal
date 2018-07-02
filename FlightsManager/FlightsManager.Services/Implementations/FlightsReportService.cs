using FlightsManager.DataTransferObjects.Reports.Flights;
using FlightsManager.Model.Entities;
using FlightsManager.Data.Implementations.Repositories;
using FlightsManager.Data.Interfaces.Repositories;
using FlightsManager.Services.Implementations.Commands;
using FlightsManager.Services.Interfaces;
using FlightsManager.Services.Interfaces.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightsManager.Services.Implementations
{
    public class FlightsReportService : IFlightsReportService
    {
        private readonly IRepository<Flight> flightRepository;
        private readonly IGetFlightReportDTOCommand getFlightReportDTOCommand;

        public FlightsReportService()
        {
            this.flightRepository = new FlightRepository();
            this.getFlightReportDTOCommand = new GetFlightReportDTOCommand();
        }

        public IEnumerable<FlightReportDTO> GetFlightsReport()
        {
            var flights = this.flightRepository.GetAll();

            return flights
                .Select(x => this.getFlightReportDTOCommand.Execute(x));
        }
    }
}