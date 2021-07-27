using MVC8amTigerBatch_09_07_2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC8amTigerBatch_09_07_2021.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index(int? id)
        {
            return View();
        }
  
        public string Index(EmployeeModel emp)
        {

            return "jjj";
        }
    }
}