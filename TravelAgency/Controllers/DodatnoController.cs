using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAgency.Filter;

namespace TravelAgency.Controllers
{
    [LoggedInAgent]
    public class DodatnoController : Controller
    {
        [ActionName("Kalendar")]
        // GET: DodatnoController
        public ActionResult Index()
        {
            return View();
        }
       

    }
}
