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

        public ViewResult GetMeView()
        {
            return View("");
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

        public ViewResult SendData4()
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

        public RedirectResult GoToGoogle()
        {
            return Redirect("http://www.google.com");

        }

        public RedirectResult GoToEmployeeDepartment()
        {
            return Redirect("~/new/SendData4");
        }

        public ActionResult PartialViewExample()
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
            return View(listObj);
        }
        public PartialViewResult PartialViewExample2()
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
            return PartialView("_MyPartialView", listObj);
        }

        public JsonResult getjsonData()
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

            return Json(listObj, JsonRequestBehavior.AllowGet);
        }

        public ViewResult TestJson()
        {
            return View();
        }

        public FileResult GetFile()
        {
            return File("~/Web.config","text/plain");
        }
        public FileResult GetFile1()
        {
            return File("~/ActionResult.pdf", "application/pdf");
        }
        public FileResult GetFile2()
        {
            return File("~/ActionResult.pdf", "application/pdf", "ActionResultKayka.pdf");
        }

        public ContentResult GetContent(int? id)
        {
            if (id == 1)
            {
                return Content("hello");
            }
            if (id == 2)
            {
                return Content("<p style=color:gray>hello</p>");
            }
            if (id == 3)
            {
                return Content("<script>alert('hello')</script>");
            }
            else
            {
                return Content("Done");

            }
        }

        public RedirectToRouteResult MoveTOOtherAction()
        {
            return RedirectToRoute("Default1");
        }
        public RedirectToRouteResult MoveTOOtherAction1()
        {
            return RedirectToAction("Index", "Default",new {id=1});
        }
        public RedirectToRouteResult MoveTOOtherAction2()
        {
            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 1212;
            obj1.EmpName = "Rajesh";
            obj1.EmpSalary = 22000;

            return RedirectToAction("Index", "Default", obj1);
        }
        public ActionResult TestView()
        {
            return View();
        }

        public ActionResult HtmlHelperExample()
        {
            VTSRMDBEntities db = new VTSRMDBEntities();
            EmployeeModel em = new EmployeeModel();
            em.EmpName = "SagaRika";
            ViewData["asfas"] = "asdfa";
            ViewBag.Books = new SelectList(db.LibraryModels.ToList(), "BookId", "BookName");
            return View(em);
        }


        public ActionResult ViewBagExample()
        {
            ViewBag.test1 = 1;
            ViewData["test2"] = 123;
            TempData["test3"] = 456;
            return RedirectToAction("ViewBagExample2");
        }
        public ActionResult ViewBagExample2()
        {
          var t1=  ViewBag.test1;
          var t2=  ViewData["test2"];
            //var t3=  TempData["test3"] ;
            var t3 = TempData.Peek("test3");

            //TempData.Keep();
            ViewBag.t4 = t1;
          ViewBag.t5 = t2;
          ViewBag.t6 = t3;
            return View();
        }

        public ActionResult ValidationExample()
        {
            return View();
        }
    }
}