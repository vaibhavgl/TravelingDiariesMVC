using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TravelingDiaries.Models;

namespace TravelingDiaries.Controllers
{
    public class FlightReservation : Controller
    {
        private readonly AppDbContext appDbContext;
        private readonly IHttpContextAccessor httpContextAccessor;

        public FlightReservation(AppDbContext appDbContext, IHttpContextAccessor httpContextAccessor)
        {
            this.appDbContext = appDbContext;
            this.httpContextAccessor = httpContextAccessor;
        }

        public IActionResult FlightTable()
        {
            var table = appDbContext.Flights;
            return View(table);
        }

        public IActionResult SearchFlight(SearchFlight? s)
        {
            ViewBag.First = 0;
            if (s.From == null)
            {
                ViewBag.First = 1;
            }
            var ListOfFlights = appDbContext.Flights.Where(x => x.From == s.From && x.To == s.To);

            string[] city = { "Jaipur", "Delhi", "Chennai", "Mumbai", "Jammu & Kashmir" };
            ViewData["City"] = city;
            ViewData["Flights"] = ListOfFlights;
            ViewBag.Number = ListOfFlights.Count();
            ViewBag.Same = 0;

            TempData["FlightDate"] = s.Date;
            if (s.From == s.To)
            {
                ViewBag.Same = 1;
            }
            return View();
        }

        [Authorize]
        public IActionResult BookFlight(int id)
        {
            TempData["Flight"] = id;
            TempData["Date"] = TempData["FlightDate"];


            TempData["Back1"] = TempData["Back"];
            return View();
        }

        public IActionResult Booking(FlightBooking ticket)
        {
            string Userid = httpContextAccessor.HttpContext.User.Identity.Name;

            ticket.CartID = Userid;
            int id = (int)TempData["Flight"];
            ticket.FlightId = id;
            ticket.FlightInfo = appDbContext.Flights.FirstOrDefault(x => x.FlightId == id);

            ticket.TicketPrice = 1500;
            if (ticket.Class == "Business")
            {
                ticket.TicketPrice = 4500;
            }
            else if (ticket.Class == "Private") {

                ticket.TicketPrice = 6500;
            }



            DateTime defaultdate = new DateTime();
            if (ticket.DateOfFlight == defaultdate)
            {
                ticket.DateOfFlight = (DateTime)TempData["Date"];
            }

            appDbContext.FlightBooking.Add(ticket);
            appDbContext.SaveChanges();

            return View(ticket);
        }

        public IActionResult Payment(int id)
        {
            TempData["Back2"] = TempData["Back1"];
            Flight flight = appDbContext.Flights.FirstOrDefault(x => x.FlightId == id);
            return View(flight);
        }


        public IActionResult BookRoundFlight(int id)
        {

            Flight flight = appDbContext.Flights.FirstOrDefault(x => x.FlightId == id);

            var ListOfFlights = appDbContext.Flights.Where(x => x.From == flight.To && x.To == flight.From);


            ViewData["Flights"] = ListOfFlights;
            ViewBag.Number = ListOfFlights.Count();
            TempData["Back"] = 1;

            return View();
        }

        [Authorize]
        public IActionResult BookingCart()
        {
            string Userid = httpContextAccessor.HttpContext.User.Identity.Name;

            var AllTickets = appDbContext.FlightBooking.Where(s => s.CartID == Userid);

            if (Userid == "admin@gmail.com")
            {
                AllTickets = appDbContext.FlightBooking;
            }

            return View(AllTickets);
        }

        public IActionResult Details(int id)
        {

            string Userid = httpContextAccessor.HttpContext.User.Identity.Name;
            var passenger = appDbContext.FlightBooking.FirstOrDefault(x => x.PassengerId == id);

            passenger.FlightInfo = appDbContext.Flights.FirstOrDefault(x => x.FlightId == passenger.FlightId);

            var a = 1;
            return View(passenger);
        }

        public IActionResult Delete(int id)
        {
            var passenger = appDbContext.FlightBooking.FirstOrDefault(x => x.PassengerId == id);

            passenger.FlightInfo = appDbContext.Flights.FirstOrDefault(x => x.FlightId == passenger.FlightId);

            appDbContext.FlightBooking.Remove(passenger);

            appDbContext.SaveChanges();

            return RedirectToAction("BookingCart");
        }
    }
}
