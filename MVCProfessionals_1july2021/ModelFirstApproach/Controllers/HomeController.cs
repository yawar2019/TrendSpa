﻿using ModelFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelFirstApproach.Filter;
using System.Web.Security;

namespace ModelFirstApproach.Controllers
{

    public class HomeController : Controller
    {
        // GET: Home

        [CustomFilter]

        public ActionResult Index()
        {
            ViewBag.Player = "Dhoni";
            return View();
        }


        [Authorize(Roles = "Admin")]
        public ActionResult About()
        {
            return View();
        }


        [Authorize(Roles = "Manager")]
        public ActionResult ContactUS()
        {
            return View();
        }

        [Authorize(Roles = "Admin,Manager")]
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return Redirect("~/home/login");
        }



        public ActionResult HtmlHelperExample()
        {
            EmployeeModelContainer db = new EmployeeModelContainer();
            EmployeeModel emp = new EmployeeModel();
            emp.EmpName = "john";
            ViewBag.Employees = new SelectList(db.EmployeeModels.ToList(), "EmpId", "EmpName");
            return View(emp);
        }

        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(UserDetail user)
        {
            EmployeeEntities db = new EmployeeEntities();
            UserDetail Reguser = db.UserDetails.Where(s => s.UserName == user.UserName && s.Password == user.Password).SingleOrDefault();

            if (Reguser != null)
            {
                FormsAuthentication.SetAuthCookie(Reguser.UserName, false);
                return Redirect("~/home/Dashboard");
            }                                 

            return View();
        }
       
        
    }
}