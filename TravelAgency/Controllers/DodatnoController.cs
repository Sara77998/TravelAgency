using Data.UnitOfWork;
using Domain;
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
        private readonly IUnitOfWork uow;

        public DodatnoController(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        // GET: DodatnoController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetEvents()
        {
            List<Kalendar> events = uow.Kalendar.GetAll();
            return Json(events.Select(e => new {
                id = e.KalendarID,
                title = e.Dogadjaj,
                description = e.Detalji,
                start = e.Pocetak,
                end = e.Kraj,
                color = e.Boja,
                allDay = e.CeoDan
            }).ToList());
        }

       
        public ActionResult Create()
        {
            return View("Create");
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm]Kalendar kalendar)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    ModelState.AddModelError("", "Sva polja su obavezna!");
                    return View("Create");
                }
                if(kalendar.Kraj != null)
                {
                    if (DateTime.Compare(kalendar.Pocetak, (DateTime)kalendar.Kraj) > 0)
                    {
                        ModelState.AddModelError("", "Neispravno uneti datumi, proveriti!");
                        return View("Create");
                    }
                }
                

                uow.Kalendar.Add(kalendar);
                uow.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("Create");
            }
        }
    }
}
