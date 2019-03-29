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

		public static string ConnectionString = "@Server=serveradress;Database=mydatabase;User Id=myusername;Password=mypassword;";
		SqlConnection Connection = new SqlConnection(ConnectionString);

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult CreateTrip()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
		}

		public IActionResult Employees()
		{
			using(OleD)
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
