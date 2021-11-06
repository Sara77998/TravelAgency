using Data.UnitOfWork;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAgency.Controllers
{
    public class GostController : Controller
    {
        private readonly IUnitOfWork uow;

        public GostController(IUnitOfWork uow)
        {
            this.uow = uow;
        }





        // GET: GostController
        public ActionResult Index()
        {
            List<Gost> model = uow.Gost.GetAll().ToList();
            return View(model);
        }




        // GET: GostController/Details/5
        public ActionResult Details(int id)
        {
            Gost model = uow.Gost.FindById(id);
            return View(model);
        }





        // GET: GostController/Create
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: GostController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm]Gost gost)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("Create");
                }
                bool exists = uow.Gost.Search(g => g.GostID == gost.GostID).Any();
                if (exists)
                {
                    ModelState.AddModelError("GostID", "Ovaj gost vec postoji u sistemu!");
                    return View("Create");
                }
                uow.Gost.Add(gost);
                uow.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("Create");
            }
        }





        // GET: GostController/Edit/5
        public ActionResult Edit(int id)
        {
            Gost model = uow.Gost.FindById(id);
            return View(model);
        }

        // POST: GostController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Gost gost)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(gost);
                }
                
                uow.Gost.Update(gost);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }




        // GET: GostController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GostController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
