using Gridview.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gridview.Controllers
{
    public class HomeController : Controller
    {
        private EmployeeDBEntities db = new EmployeeDBEntities();

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Index1()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(login l)
        {
            var user = db.UserModels.Where(a => a.Email.Equals(l.Email)).FirstOrDefault();
            if (user != null)
            {
                if ((user.Password == l.Password))
                {
                    return RedirectToAction("Index1");
                }
                else
                {
                    ViewBag.flag = 1;
                    return View();
                }
            }
            else
            {
                ViewBag.flag = 2;
                return View();
            }

        }

        public ActionResult BindGrid([DataSourceRequest] DataSourceRequest request)
        {
                List<Models.UserModel> lst = new List<Models.UserModel>();
                lst = GetGridData().ToList();
                DataSourceResult result = lst.ToDataSourceResult(request, p => new Models.UserModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    City = p.City,
                    Email = p.Email,

                });
                return Json(result, JsonRequestBehavior.AllowGet);
            
        }
        public IEnumerable<Models.UserModel> GetGridData()
        {
            return db.UserModels.ToList().AsEnumerable();
        }



    }
}
