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
            return "My Employee Id is " + id;
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

        public ActionResult SendMultipleEmpData()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();



            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1211;
            obj.EmpName = "Teja";
            obj.EmpSalary = 12000;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 1212;
            obj1.EmpName = "Rajesh";
            obj1.EmpSalary = 22000;


            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 1213;
            obj2.EmpName = "Narendra Bahubali";
            obj2.EmpSalary = 24000;

            EmployeeModel obj3 = new EmployeeModel();
            obj3.EmpId = 1214;
            obj3.EmpName = "Manas";
            obj3.EmpSalary = 26000;

            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);
            listObj.Add(obj3);

            ViewBag.info = listObj;


            return View();
        }

        public ActionResult SendData3()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1211;
            obj.EmpName = "Teja";
            obj.EmpSalary = 12000;

            //object model = obj;

            return View(obj);
        }

        public ActionResult SendData4()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1211;
            obj.EmpName = "Teja";
            obj.EmpSalary = 12000;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 1212;
            obj1.EmpName = "Rajesh";
            obj1.EmpSalary = 22000;


            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 1213;
            obj2.EmpName = "Narendra Bahubali";
            obj2.EmpSalary = 24000;

            EmployeeModel obj3 = new EmployeeModel();
            obj3.EmpId = 1214;
            obj3.EmpName = "Manas";
            obj3.EmpSalary = 26000;

            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);
            listObj.Add(obj3);

            List<DepartmentModel> listdept = new List<DepartmentModel>();

            DepartmentModel dept = new Models.DepartmentModel();
            dept.DeptId = 1;
            dept.DeptName = "IT";

            DepartmentModel dept1 = new Models.DepartmentModel();
            dept1.DeptId = 2;
            dept1.DeptName = "Network";

            listdept.Add(dept);
            listdept.Add(dept1);

            EmpDept empDeptObj = new EmpDept();
            empDeptObj.Emp =listObj;
            empDeptObj.Dept = listdept;

            return View(empDeptObj);
        }

    }
}