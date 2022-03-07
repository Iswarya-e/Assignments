using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment9MVC3.Models;
namespace Assignment9MVC3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Registration()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Registration(Employee e)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Display", e);
            }
            return View(e);

        }
        public ActionResult Display(Employee e)
        {
            ViewBag.Fname = e.FName;
            ViewBag.LName=e.LName;
            ViewBag.Age=e.Age;
            ViewBag.email = e.Email;
            ViewBag.Gender=e.Gender;
            ViewBag.address = e.Address;
            ViewBag.city=e.City;
            ViewBag.state=e.State;
            ViewBag.mobile = e.Mobile_number;
            ViewBag.eq = e.Educational_Qualification;

            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Service()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }

    }
}