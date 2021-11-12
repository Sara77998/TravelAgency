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
    [LoggedInAgent]
    public class AgentController : Controller
    {
        private readonly IUnitOfWork uow;

        public AgentController(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        // GET: UserController
        [NotLoggedIn]
        public ActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(LoginVM model)
        {
            try
            {
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
                ModelState.AddModelError(string.Empty, "Losi podaci!");
                return View();
            }
           
        }
        //[HttpPost]
        //public ActionResult Login(LoginViewModel model)
        //{
        //    try
        //    {
        //        User user = unit.Users.GetByUsernameAndPassword(new User { Username = model.Username, Password = model.Password });
        //        HttpContext.Session.SetInt32("userid", user.UserId);
        //        HttpContext.Session.SetString("username", user.Username);

        //        HttpContext.Session.Set("user", JsonSerializer.SerializeToUtf8Bytes(user));
        //        //ViewBag.IsLoggedIn = true;
        //        return RedirectToAction("Index", "Department");
        //    }
        //    catch (Exception ex)
        //    {
        //        ModelState.AddModelError(string.Empty, "Wrong credentials!");
        //        return View();
        //    }
        //}

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [NotLoggedIn]
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
            if (uow.Agent.Search(u => u.Username == model.Username).Any())
            {
                ModelState.AddModelError(string.Empty, "Username is taken!");
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
