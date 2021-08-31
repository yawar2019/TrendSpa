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

        public ActionResult TestWebService()
        {
            ServiceReference1.CalculatorSoapClient obj = new ServiceReference1.CalculatorSoapClient();
            var result=obj.Add(10, 20);
            return Content(result.ToString());
        }

        public ActionResult TestWCFServiceForHttpClient()
        {
            ServiceReference2.Service1Client obj = new ServiceReference2.Service1Client("WSHttpBinding_IService1");
            var result = obj.Add(10, 20);
            return Content(result.ToString());
        }

        public ActionResult TestWCFServiceForTcpClient()
        {
            ServiceReference2.Service1Client obj = new ServiceReference2.Service1Client("NetTcpBinding_IService1");
            var result = obj.Add(10, 20);
            return Content(result.ToString());
        }
    }
}