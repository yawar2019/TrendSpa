using ModelFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelFirstApproach.Filter;
namespace ModelFirstApproach.Controllers
{

    public class HomeController : Controller
    {
        // GET: Home

        [CustomFilter]

        public ActionResult Index()
        {
            ViewBag.Player = "Dhoni";
            return View();
        }
       
        public ActionResult About()
        {
            return View();
        }

        public ActionResult ContactUS()
        {
            return View();
        }

        public ActionResult HtmlHelperExample()
        {
            EmployeeModelContainer db = new EmployeeModelContainer();
            EmployeeModel emp = new EmployeeModel();
            emp.EmpName = "john";
            ViewBag.Employees = new SelectList(db.EmployeeModels.ToList(), "EmpId", "EmpName");
            return View(emp);
        }
    }
}