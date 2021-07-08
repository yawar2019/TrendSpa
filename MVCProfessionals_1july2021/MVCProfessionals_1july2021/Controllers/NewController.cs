using MVCProfessionals_1july2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProfessionals_1july2021.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        public ActionResult Index()
        {
           ViewBag.batchName = Index5();

            return View();
        }
      
        public string Index5()
        {
            return "MVC10pmBatch";
        }

        private int Index1()
        {
            return 1211;
        }

        public string Index2()
        {
            return "My Employee Id is 1211";
        }
        
        public string Index3(int? eid,string name)
        {
            return "My Employee Id is "+eid+" name "+name;
        }

        public string Index4(int? eid)
        {
            return "My Employee Id is " + eid + " name " + Request.QueryString["name"];
        }

        public ActionResult SendEmployeeInfo()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1211;
            obj.EmpName = "Amith";
            obj.EmpSalary = 670000;

            ViewBag.emp = obj;

            return View("Index");
        }

        public ActionResult SendEmployeeInfo2()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1211;
            obj.EmpName = "Amith";
            obj.EmpSalary = 670000;

            ViewBag.emp = obj;

            return View("~/Views/Default/Index.cshtml");
        }

        public ActionResult SendEmployeeInfo3()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1211;
            obj.EmpName = "Amith";
            obj.EmpSalary = 670000;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 1212;
            obj1.EmpName = "Umesh";
            obj1.EmpSalary = 770000;

            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 1213;
            obj2.EmpName = "vrushali";
            obj2.EmpSalary = 670000;

            EmployeeModel obj3 = new EmployeeModel();
            obj3.EmpId = 1214;
            obj3.EmpName = "Renuka";
            obj3.EmpSalary = 870000;

            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);
            listObj.Add(obj3);

            ViewBag.emp = listObj;

            return View();
        }

        public ActionResult SendEmployeeInfo12()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1211;
            obj.EmpName = "Amith";
            obj.EmpSalary = 670000;

            return View(obj);
        }

        public ActionResult SendEmployeeInfo13()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1211;
            obj.EmpName = "Amith";
            obj.EmpSalary = 670000;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 1212;
            obj1.EmpName = "Umesh";
            obj1.EmpSalary = 770000;

            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 1213;
            obj2.EmpName = "vrushali";
            obj2.EmpSalary = 670000;

            EmployeeModel obj3 = new EmployeeModel();
            obj3.EmpId = 1214;
            obj3.EmpName = "Renuka";
            obj3.EmpSalary = 870000;

            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);
            listObj.Add(obj3);



            return View(listObj);
        }

    }
}

//1)clear
//2)clear