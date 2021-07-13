using MVC8amTigerBatch_09_07_2021.Models;
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
            string result = GetName3();
            return result;
        }
        [NonAction]
        public string GetName2()
        {
            return "Vinod";
        }

        private string GetName3()
        {
            return "Vinod";
        }

        public ActionResult GetMeView()  
        {
            return View();
        }


        public string GetEmpId(int id)
        {
            return "My Employee Id is "+id;
        }

        public ActionResult SendData()
        {
            ViewBag.info = "Hello";
            return View();
        }

        public ActionResult SendData1()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1211;
            obj.EmpName = "Teja"; 
            obj.EmpSalary = 12000;

            ViewBag.info = obj;
            return View();
        }
    }
}