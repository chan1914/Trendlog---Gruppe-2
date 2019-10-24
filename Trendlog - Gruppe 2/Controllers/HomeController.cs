using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trendlog___Gruppe_2.Models;

namespace Trendlog___Gruppe_2.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
            BandwidthStats.GeneatedLeads = 10;
            BandwidthStats.ServerAllocation = 30;
            BandwidthStats.SubmittedTickers = 60;


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
