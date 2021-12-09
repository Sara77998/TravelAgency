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
    public class GostController : Controller
    {
        private readonly IUnitOfWork uow;

        public GostController(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        // GET: GostController
        
        public ActionResult Index(string searching)
        {
            var gosti = uow.Gost.GetAll();
          
                if (!String.IsNullOrEmpty(searching))
                {
                gosti = gosti.Where(g => g.Ime.Contains(searching) || g.Prezime.Contains(searching) || g.Pasos.Contains(searching)).ToList();
                    
                }                           
            return View(gosti.ToList());
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
                bool exists = uow.Gost.Search(g => g.Pasos == gost.Pasos).Any();
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
                uow.Commit();
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
            Gost model = uow.Gost.FindById(id);
            return View(model);
        }

        // POST: GostController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        //zasto se ovde prosledjuje ceo objekat kad je dovoljno sto imamo id
        public ActionResult Delete(int id, [FromForm]Gost model)
        {
            try
            {
                Gost gost = uow.Gost.FindById(id);
                if (gost == null)
                {
                    return NotFound();
                }
                uow.Gost.Delete(gost);
                uow.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
