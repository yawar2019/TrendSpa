using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdoNetExample.Models;
using PagedList.Mvc;
using PagedList;
namespace AdoNetExample.Controllers
{
    public class HomeController : Controller
    {
        // GetEmployeeDetails
        // GET: Home
        EmployeeContext db = new EmployeeContext();

        public ActionResult Index(int? i)
        {
            var employees = db.GetEmployeeDetails().ToPagedList(i??1,4);
            return View(employees);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string EmpName1,int?EmpSalary)
        {
            return View();
        }
    }
}