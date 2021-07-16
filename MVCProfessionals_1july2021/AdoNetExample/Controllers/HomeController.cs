using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdoNetExample.Models;
namespace AdoNetExample.Controllers
{
    public class HomeController : Controller
    {
        // GetEmployeeDetails
        // GET: Home
        EmployeeContext db = new EmployeeContext();

        public ActionResult Index()
        {
            List<EmployeeModel> employees = db.GetEmployeeDetails();
            return View(employees);
        }
    }
}