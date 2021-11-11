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
using TravelAgency.Models;

namespace TravelAgency.Controllers
{
    [LoggedInAgent]
    public class RezervacijaController : Controller
    {
        private readonly IUnitOfWork uow;

        public RezervacijaController(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        // GET: RezervacijaController
        public ActionResult Index()
        {
            List<Rezervacija> model = uow.Rezervacija.GetAll();
            return View(model);
        }

        // GET: RezervacijaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RezervacijaController/Create
        public ActionResult Create()
        {
            List<SelectListItem> agenti = new List<SelectListItem>();
            foreach (Agent a in uow.Agent.GetAll())
            {
                agenti.Add(new SelectListItem
                {
                    Value = a.AgentID.ToString(),
                    Text = a.Ime + ' ' + a.Prezime
                });
            }
            //prosledjuje se lista agenata
            ViewBag.agenti = agenti;


            List<SelectListItem> sobe = new List<SelectListItem>();
            foreach (Soba s in uow.Soba.GetAll())
            {
                sobe.Add(new SelectListItem
                {
                    Value = s.SobaID.ToString(),
                    Text = s.BrojSobe + ' ' + s.TipSobe
                });
            }
            //prosledjuje se lista soba
            ViewBag.sobe = sobe;


            List<Gost> lista = uow.Gost.GetAll();
            List<SelectListItem> selectLista = lista.Select(g => new SelectListItem
            {
                Text = g.Ime +" "+g.Prezime,
                Value = g.GostID.ToString()
            }).ToList();

            RezervacijaVM model = new RezervacijaVM
            {
                Gosti = selectLista
            };
            return View(model);
        }

        // POST: RezervacijaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RezervacijaVM model)
        {
            try
            {
                uow.Rezervacija.Add(model.Rezervacija);
                uow.Commit();
                return RedirectToAction("Index", "Hotel");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return RedirectToAction("Create");
            }
        }

        // GET: RezervacijaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RezervacijaController/Edit/5
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

        // GET: RezervacijaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RezervacijaController/Delete/5
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
        [HttpPost]
        public ActionResult AddGost(StavkaRezervacijeVM request)
        {
            Gost gost = uow.Gost.FindById(request.GostID);
            StavkaRezervacijeVM model = new StavkaRezervacijeVM
            {
                Rb = request.Rb,
                GostID = request.GostID,
                Pasos = gost.Pasos,
                Ime = gost.Ime,
                Prezime = gost.Prezime
            };
            return PartialView("StavkeRezervacijePartial", model);
        }
    }
}
