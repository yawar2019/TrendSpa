using ControlsExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlsExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        EmployeeEntities db = new EmployeeEntities();
        public ActionResult Index()
        {
            ViewBag.Employees = new SelectList(db.employeeDetails.ToList(), "EmpId", "EmpName");
            return View();
        }
        [HttpPost]
        public ActionResult Index(int? Employees)
        {
            ViewBag.Employees = new SelectList(db.employeeDetails.ToList(), "EmpId", "EmpName");
            var selectedEmployee = db.employeeDetails.Where(s => s.EmpId == Employees).SingleOrDefault();

            ViewBag.SelectedEmployee = selectedEmployee.EmpId+","+selectedEmployee.EmpName;

            return View();
        }

        public ActionResult RadioButtonList()
        {
            var Employees = db.employeeDetails.ToList();
            return View(Employees);
        }

        [HttpPost]
        public ActionResult RadioButtonList(List<employeeDetail> item)
        {
            var Employees = db.employeeDetails.ToList();

            //var EmployeeInfo = db.employeeDetails.Where(s => s.EmpId == item.EmpId).FirstOrDefault();
            //ViewBag.selectedEmployee = EmployeeInfo;

            return View(Employees);

        }
    }
}