using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc.Models;
namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            
            List<Product> Ilist = new List<Product>{ 
                new Product(){ Id=101,Name="ABC"},
                new Product(){ Id=102,Name="BCD"}
            };
        return View(Ilist);
        }
        public ActionResult Student()
            
        {
            ViewBag.Message =  TempData["Message"].ToString();
           
            return View();
        }
       

    }
}