using ModelFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelFirstApproach.Controllers
{
    public class ValidationController : Controller
    {
        // GET: Validation
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(RegisterModel reg)
        {
            if(ModelState.IsValid)
            {
                //pass
            }
            else
            {
                //fail
            }
            return View();
        }
    }
}