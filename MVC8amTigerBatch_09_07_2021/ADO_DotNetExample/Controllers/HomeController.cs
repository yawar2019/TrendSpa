using ADO_DotNetExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace ADO_DotNetExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        EmployeeContext db = new EmployeeContext();
        public ActionResult Index(int? PageNumber)
        {
            return View(db.GetAllEmployees().ToPagedList(PageNumber??1, 3));
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(string EmpName,int EmpSalary)
        {
            return View();
        }
    }
}