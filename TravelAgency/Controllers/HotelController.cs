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
    public class HotelController : Controller
    {
        private readonly IUnitOfWork uow;

        public HotelController(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        // GET: HotelController
        public ActionResult Index()
        {
            List<Hotel> hoteli = uow.Hotel.GetAll().ToList();
            return View(hoteli);
        }

        // GET: HotelController/Details/5
        public ActionResult Details([FromRoute] int id)
        {
            Hotel model = uow.Hotel.FindById(id);
            return View(model);
        }





        // GET: HotelController/Create
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: HotelController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Hotel hotel)
        {
            if (!ModelState.IsValid)
            {
                return View("Create");
            }
            bool exists = uow.Hotel.Search(h => h.Naziv == hotel.Naziv).Any();
            if (exists)
            {
                ModelState.AddModelError("HotelNaziv", "Ovaj hotel vec postoji u sistemu!");
                return View("Create");
            }
            uow.Hotel.Add(hotel);
            uow.Commit();
            return RedirectToAction(nameof(Index));
        }




        //public ActionResult Delete(int id)
        //{
        //    return Index();
            
        //}

        // POST: HotelController/Delete/5
        
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var hotel = uow.Hotel.FindById(id);
            if (hotel == null)
            {
                return NotFound();
            }
            uow.Hotel.Delete(hotel);
            uow.Commit();

            return RedirectToAction(nameof(Index));
        }
    }
}
