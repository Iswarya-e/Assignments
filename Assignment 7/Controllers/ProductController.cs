using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc.Models;
namespace mvc.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Display1()
        {
            List<Product> empList = new List<Product>{
                new Product() { Id = 101, Name = "ABC" } ,
                new Product() { Id = 102, Name = "BCD"} ,
                new Product() { Id = 103, Name = "CDE" }

            };
            return View(empList);
        }
    }
}