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
			try
			{
				Connection.Open();
				SqlDataReader Reader = null;
				SqlCommand getEmployeesCommand = new SqlCommand("select here", Connection);
				Reader = getEmployeesCommand.ExecuteReader();
				while (Reader.Read())
				{
					//Reader["emp_fname"].ToString()
					// manager_id = name
					// dept_id = name
					// job_id = name
					Console.WriteLine(String.Format("%s | %s | %s | %s", 
						Reader["emp_id"].ToString(), 
						Reader["manager_id"].ToString(), 
						Reader["emp_fname"].ToString(), 
						Reader["emp_lname"].ToString(), 
						Reader["dept_id"].ToString(), 
						Reader["street"].ToString(),
						Reader["city"].ToString(),
						Reader["state"].ToString(),
						Reader["zip_code"].ToString(),
						Reader["job_id"].ToString(),
						Reader["phone"].ToString(),
						Reader["status"].ToString(),
						Reader["ss_number"].ToString(),
						Reader["salary"].ToString(),
						Reader["start_date"].ToString(),
						Reader["termination_date"].ToString(),
						Reader["birth_date"].ToString(),
						Reader["bene_health_ins"].ToString(),
						Reader["bene_life_care"].ToString(),
						Reader["bene_day_care"].ToString()));
				}

			} catch (Exception e)
			{
				Console.WriteLine(e.ToString());
			}
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
