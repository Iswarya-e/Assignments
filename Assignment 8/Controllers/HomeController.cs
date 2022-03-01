using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment8.Models;

namespace Assignment8.Controllers
{
    public class HomeController : Controller
    {
        List<Employee> list = new List<Employee>();

        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Employee e)
        {
            if (ModelState.IsValid)
            { 
                if (e.Age<18)
                {
                    return RedirectToAction("errorAge");
                }
                else if (e.City == "Mumbai")
                {
                    return RedirectToAction("Index2",e);
                }
                else
                {
                    return RedirectToAction("errorCity");
                }
            }
            return View(e);
        }

        public ActionResult Index2(Employee e)
        {
            list.Add(new Employee { Id=e.Id,Name=e.Name,Age=e.Age,City=e.City});
            //ViewBag.Id=e.Id;
            //ViewBag.Name = e.Name;
            //ViewBag.Age = e.Age;
            //ViewBag.City = e.City;
            return View(list);
        }
        public ActionResult errorAge()
        {
            return View();
        }
        public ActionResult errorCity()
        {

            return View();
        }
    }
}