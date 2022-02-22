using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc.Models;

namespace mvc.Controllers

{
    public class EmployeeController : Controller
    {
       
        // GET: Employee
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult DisplayAll()
        {
                List<Employee> empList = new List<Employee>{
                new Employee() { id = 101, Name = "ABC", Age = 44,City="Mumbai" } ,
                new Employee() { id = 102, Name = "BCD", Age = 55,City="Mumbai" } ,
                new Employee() { id = 103, Name = "CDE", Age = 33,City="Mumbai" }

            };
            TempData["EmployeeList"] = empList;
            TempData.Keep();

            return View(empList);
        }
        public ActionResult Display2()
        {
            ViewBag.emp = TempData["EmployeeList"];
            return View();
        }





    }
}