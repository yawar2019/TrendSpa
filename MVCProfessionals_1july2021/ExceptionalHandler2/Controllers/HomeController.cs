using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExceptionalHandler2.Controllers
{
    //[HandleError(View = "FormatExceptionError")]

    public class HomeController : Controller
    {
        public ActionResult Index(string id)
        {
            try
            {
                int a = Convert.ToInt32(id);
                ViewBag.id = a;
            }
            catch (Exception)
            {

                throw;
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CreateError(string id)
        {
            try
            {
                int a = Convert.ToInt32(id);
                ViewBag.id = a;
            }
            catch (Exception)
            {

                throw;
            }
           
            return View();
        }

    }
}