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

		public IActionResult CreateTrip()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
		}

		public IActionResult Employees()
		{
			
			ViewData["Message"] = "Your contact page.";

			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
