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
        public ActionResult Create(EmployeeModel emp)
        {
            int i=db.SaveEmployee(emp);
            if (i > 0)
            {
                return RedirectToAction("index");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            EmployeeModel Emp = db.GetEmployeeDetailsById(id);
            return View(Emp);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel emp)
        {
            int i = db.UpdateEmployee(emp);
            if (i > 0)
            {
                return RedirectToAction("index");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            EmployeeModel Emp = db.GetEmployeeDetailsById(id);
            return View(Emp);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            int i = db.DeleteEmployee(id);
            if (i > 0)
            {
                return RedirectToAction("index");
            }
            else
            {
                return View();
            }
        }
    }
}