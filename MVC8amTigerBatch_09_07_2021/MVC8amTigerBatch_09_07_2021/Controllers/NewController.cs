using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC8amTigerBatch_09_07_2021.Controllers
{
    public class NewController : Controller
    {

        public string GetName()
        {
            return "Vinod";
        }

        public ActionResult GetMeView()  
        {
            return View();
        }

    }
}