using FlightsManager.DataTransferObjects.Reports.Flights;
using FlightsManager.Services.Implementations;
using FlightsManager.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlightsManager.Controllers.Reports.Flights
{
    public class FlightsReportController : Controller
    {
        private IFlightsReportService flightsReportService;

        public FlightsReportController()
        {
            this.flightsReportService = new FlightsReportService();
        }

        // GET: FlightsReport/Index
        public ActionResult Index()
        {
            var flightReportDTOs = this.flightsReportService.GetFlightsReport();

            return View(flightReportDTOs);
        }
    }
}