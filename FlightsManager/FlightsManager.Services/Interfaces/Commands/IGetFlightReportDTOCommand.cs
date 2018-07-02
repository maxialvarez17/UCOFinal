using FlightsManager.DataTransferObjects.Reports.Flights;
using FlightsManager.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightsManager.Services.Interfaces.Commands
{
    public interface IGetFlightReportDTOCommand
    {
        FlightReportDTO Execute(Flight flight);
    }
}