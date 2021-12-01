using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using TravelAgency.Filter;
using TravelAgency.Models;

namespace TravelAgency.Controllers
{
    [LoggedInAgent]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            
            _logger = logger;
        }
        [NotLoggedIn]
        public IActionResult Index()
        {
            int? agentid = HttpContext.Session.GetInt32("agentid");
            if(agentid != null)
            {
                ViewBag.IsLoggedIn = true;
                ViewBag.Username = HttpContext.Session.GetString("username");
                byte[] agentBy = HttpContext.Session.Get("agent");
                Agent agent = JsonSerializer.Deserialize<Agent>(agentBy);
            }
            else
            {
                return RedirectToAction("Index", "Agent");
            }
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
