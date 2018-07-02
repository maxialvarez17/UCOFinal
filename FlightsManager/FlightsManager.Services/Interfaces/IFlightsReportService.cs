using FlightsManager.DataTransferObjects.Reports.Flights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightsManager.Services.Interfaces
{
    public interface IFlightsReportService
    {
        IEnumerable<FlightReportDTO> GetFlightsReport();
    }
}