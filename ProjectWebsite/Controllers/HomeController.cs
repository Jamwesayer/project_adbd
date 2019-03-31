using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectWebsite.Models;

using System.Data.SqlClient;

namespace ProjectWebsite.Controllers
{
	public class HomeController : Controller
	{

		private readonly OutdoorParadiseContext _context;

		public HomeController(OutdoorParadiseContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var Employees = _context.Employee.ToList();
			return View(Employees);
		}

		[HttpGet]
		public IActionResult Booking()
		{

			var Customers = _context.Customer.ToList();
			var SportTrips = _context.SportTrip.ToList();

			ViewBag.Customers = Customers;
			ViewBag.SportTrips = SportTrips;

			return View();
		}

		[HttpPost]
		public IActionResult Booking(int CustomerId, int SportTripId, bool HasInsurance, string PaymentMethod)
		{

			DateTime CurrentTimeStamp = DateTime.Now;

			_context.Booking.Add(new Models.Booking()
			{
				CustomerId = CustomerId,
				TripId = SportTripId,
				Bookingdate = CurrentTimeStamp,
				Insurance = HasInsurance,
				PaymentMethod = PaymentMethod
			});

			_context.SaveChanges();

			return RedirectToAction("index");
		}
	}
}
