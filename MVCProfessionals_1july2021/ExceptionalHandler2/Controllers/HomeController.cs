using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExceptionalHandler2.ServiceReference1;
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

        [OutputCache(Duration =20,Location =System.Web.UI.OutputCacheLocation.Client)]
        public ActionResult OutputCatcheExample()
        {
            return View();
        }

        public ActionResult GetService()
        {
            WebService1SoapClient obj = new WebService1SoapClient();
           int result= obj.Add(12, 45);
            return Content(result.ToString());
        }
    }
}