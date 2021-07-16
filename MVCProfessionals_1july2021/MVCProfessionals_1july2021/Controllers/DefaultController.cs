using MVCProfessionals_1july2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProfessionals_1july2021.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index2(int?id)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Index2(List<EmployeeModel> emp)
        {
            return View();
        }
    }
}