using Data.UnitOfWork;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using TravelAgency.Filter;
using TravelAgency.Models;

namespace TravelAgency.Controllers
{
    
    public class AgentController : Controller
    {
        private readonly IUnitOfWork uow;

        public AgentController(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        // GET: UserController
       
        public ActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(LoginVM model)
        {
            try
            {
                if (model.Username == null || model.Password == null)
                {
                    ModelState.AddModelError(string.Empty, "Morate uneti podatke za sva polja!");
                    return View();
                }
                Agent agent = uow.Agent.GetByUsernameAndPassword(new Agent
                {
                    Username = model.Username,
                    Password = model.Password
                });
                HttpContext.Session.SetInt32("agentid", agent.AgentID);
                HttpContext.Session.SetString("username", agent.Username);

                HttpContext.Session.Set("agent", JsonSerializer.SerializeToUtf8Bytes(agent));

                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "Ovaj agent ne postoji!");
                return View();
            }
           
        }
       

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

       
        // GET: UserController/Create
        [ActionName("Register")]
        public ActionResult Create()
        {
            return View("Register");
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Register")]
        public ActionResult Create(Agent model)
        {
            if (model.Ime == null || model.Prezime == null || model.Email == null || model.Username == null || model.Password == null)
            {
                ModelState.AddModelError(string.Empty, "Morate uneti podatke za sva polja!");
                return View();
            }
            if (uow.Agent.Search(u => u.Username == model.Username).Any())
            {
                ModelState.AddModelError(string.Empty, "Vec postoji agent sa tim korisnickim imenom!");
                return View();
            }
            uow.Agent.Add(new Domain.Agent { TuristickaAgencijaID = 1, Ime = model.Ime, Prezime = model.Prezime, Email = model.Email, Username = model.Username, Password = model.Password });
            uow.Commit();
            return RedirectToAction("Index");
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Agent");
        }
        [ActionName("Tim")]
        // GET: DodatnoController
        public ActionResult Index1()
        {
            List<Agent> model = uow.Agent.GetAll();
            return View(model);
        }

    }
}
