using FlightsManager.DataTransferObjects.Entities.Flights;
using FlightsManager.Services.Implementations;
using FlightsManager.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace FlightsManager.Controllers.Flights
{
    public class FlightController : Controller
    {
        private IFlightService flightService;

        public FlightController()
        {
            this.flightService = new FlightService();
        }

        // GET: Flight/Index
        public ActionResult Index()
        {
            var flights = this.flightService.GetFlights();

            return View(flights);
        }

        // GET: Flight/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Flight/Create
        public ActionResult Create()
        {
            ViewBag.Airports = this.flightService.GetAirports()
                .Select(x => new SelectListItem()
                {
                    Text = x.Description,
                    Value = x.Id.ToString()
                });

            ViewBag.Aircrafts = this.flightService.GetAircrafts()
                .Select(x => new SelectListItem()
                {
                    Text = x.Description,
                    Value = x.Id.ToString()
                });

            return View();
        }

        // POST: Flight/Create
        [HttpPost]
        public ActionResult Create(FlightSaveDTO flightSaveDTO)
        {
            try
            {
                this.flightService.CreateFlight(flightSaveDTO);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Flight/Edit/5
        public ActionResult Edit(int id)
        {
            var flightSaveDTO = this.flightService.GetFlight(id);

            ViewBag.Airports = this.flightService.GetAirports()
                .Select(x => new SelectListItem()
                {
                    Text = x.Description,
                    Value = x.Id.ToString()
                });

            ViewBag.Aircrafts = this.flightService.GetAircrafts()
                .Select(x => new SelectListItem()
                {
                    Text = x.Description,
                    Value = x.Id.ToString()
                });

            return View(flightSaveDTO);
        }

        // POST: Flight/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FlightSaveDTO flightSaveDTO)
        {
            try
            {
                this.flightService.UpdateFlight(id, flightSaveDTO);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Flight/Delete/5
        public ActionResult Delete(int id)
        {
            var flightSaveDTO = this.flightService.GetFlight(id);

            ViewBag.Airports = this.flightService.GetAirports()
                .Select(x => new SelectListItem()
                {
                    Text = x.Description,
                    Value = x.Id.ToString()
                });

            ViewBag.Aircrafts = this.flightService.GetAircrafts()
                .Select(x => new SelectListItem()
                {
                    Text = x.Description,
                    Value = x.Id.ToString()
                });

            return View(flightSaveDTO);
        }

        // POST: Flight/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                this.flightService.DeleteFlight(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
