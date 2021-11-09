using Data.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        //public ActionResult Create(RegisterViewModel model)
        //{
        //    if (unit.Users.Search(u => u.Username == model.Username).Any())
        //    {
        //        ModelState.AddModelError(string.Empty, "Username is taken!");
        //        return View();
        //    }
        //    unit.Users.Add(new Domain.User { FirstName = model.FirstName, LastName = model.Lastname, Username = model.Username, Password = model.Password });
        //    unit.Commit();
        //    return RedirectToAction("Index");
        //}

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

    }
}
