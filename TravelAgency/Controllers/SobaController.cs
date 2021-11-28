using Data.UnitOfWork;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAgency.Filter;

namespace TravelAgency.Controllers
{
    [LoggedInAgent]
    public class SobaController : Controller
    {
        private readonly IUnitOfWork uow;

        public SobaController(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        // GET: SobaController
        //public ActionResult Index()
        //{
        //    List<Soba> model = uow.Soba.GetAll();
        //    return View(model);
        //}

        public ActionResult Index(string searching)
        {
            var sobe = uow.Soba.GetAll();

            if (!String.IsNullOrEmpty(searching))
            {
                sobe = sobe.Where(s => s.BrojSobe.Contains(searching) || s.TipSobe.Contains(searching) || s.Hotel.Naziv.Contains(searching)).ToList();

            }
            return View(sobe.ToList());
        }

        // GET: SobaController/Details/5
        public ActionResult Details(int id)
        {
            Soba model = uow.Soba.FindById(id);
            return View(model);
        }

        // GET: SobaController/Create
        public ActionResult Create()
        {
            List<SelectListItem> hoteli = new List<SelectListItem>();
            foreach (Hotel h in uow.Hotel.GetAll())
            {
                hoteli.Add(new SelectListItem
                {
                    Value = h.HotelID.ToString(),
                    Text = h.Naziv
                });
            }
            //prosledjuje se lista hotela
            ViewBag.hoteli = hoteli;
            return View("Create");
        }

        // POST: SobaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm]Soba soba)
        {
           
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("Create");
                }
                Soba sobe = new Soba
                {
                    HotelID = soba.HotelID,
                    BrojSobe = soba.BrojSobe,
                    TipSobe = soba.TipSobe,
                    Zauzeta = soba.Zauzeta
                };
                uow.Soba.Add(soba);
                uow.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("Create");
            }
        }

        // GET: SobaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View("Edit");
        }

        // POST: SobaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SobaController/Delete/5
        public ActionResult Delete(int id)
        {
            Soba model = uow.Soba.FindById(id);
            return View(model);
        }

        // POST: SobaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var soba = uow.Soba.FindById(id);
                if (soba == null)
                {
                    return NotFound();
                }
                uow.Soba.Delete(soba);
                uow.Commit();

                return RedirectToAction(nameof(Index));
                
            }
            catch
            {
                return View("Index");
            }
        }
    }
}
