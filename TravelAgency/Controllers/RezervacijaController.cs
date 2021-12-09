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

            return View(Forma());
        }

        // POST: RezervacijaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RezervacijaVM model)
        {
            try
            {
            
                //provera datuma
                if (!Validations.ValidacijaRezervacije.IspravanDatum(model))
                {
                    ModelState.AddModelError("", "Neispravno uneti datumi, proveriti!");
                    return View(Forma());
                }             

                //provera da li su uneti gosti
                if (!Validations.ValidacijaRezervacije.IspravnaListaGostiju(model))
                {
                    ModelState.AddModelError("", "Rezervacija mora da sadrzi bar jednog gosta!");                   
                    return View(Forma());     
                }
                Rezervacija r = new Rezervacija
                {
                    AgentID = model.Rezervacija.AgentID,
                    SobaID = model.SobaID,
                    DatumOd = model.Rezervacija.DatumOd,
                    DatumDo = model.Rezervacija.DatumDo,
                    StavkeRezervacije = model.Rezervacija.StavkeRezervacije
                };
                uow.Rezervacija.Add(r);
                uow.Commit();
                return RedirectToAction("Index", "Rezervacija");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return RedirectToAction("Create");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateGost([FromForm] Gost gost)
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
                return RedirectToAction(nameof(Create));
            }
            catch
            {
                return View("Create");
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

        //[HttpPost]
        //[ValidateAntiForgeryToken]
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


        public RezervacijaVM Forma()
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


            List<Hotel> hoteli = uow.Hotel.GetAll();
            ViewBag.HotelList = new SelectList(hoteli, "HotelID", "Naziv");

            List<Gost> lista = uow.Gost.GetAll();
            List<SelectListItem> selectLista = lista.Select(g => new SelectListItem
            {
                Text = g.Ime + " " + g.Prezime,
                Value = g.GostID.ToString()
            }).ToList();

            RezervacijaVM model1 = new RezervacijaVM
            {
                Gosti = selectLista,
                SviGosti = lista
            };
            return model1;
        }

        public JsonResult GetSobaList(int HotelID)
        {

            List<Soba> sobe = uow.Soba.Search(s => s.HotelID == HotelID).ToList();
            return Json(sobe.Select(s => new {
                id = s.SobaID,
                brojsobe = s.BrojSobe,
                tipsobe = s.TipSobe
            }).ToList());

           
        }
    }
}
