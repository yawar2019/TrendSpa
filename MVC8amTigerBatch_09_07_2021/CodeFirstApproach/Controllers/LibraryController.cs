using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirstApproach.Models;
using ADO_DotNetExample.Models;
using System.Data.Entity;

namespace CodeFirstApproach.Controllers
{
    public class LibraryController : Controller
    {
        // GET: Library
        LibraryContext db = new LibraryContext();
        public ActionResult Index()
        {
            return View(db.LibraryModels.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(LibraryModel lib)
        {
            db.LibraryModels.Add(lib);
            int i = db.SaveChanges();
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            LibraryModel lib = db.LibraryModels.Find(id);
            return View(lib);
        }
        [HttpPost]
        public ActionResult Edit(LibraryModel lib)
        {
            db.Entry(lib).State = EntityState.Modified;
            int i = db.SaveChanges();
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            LibraryModel lib = db.LibraryModels.Find(id);
            return View(lib);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            LibraryModel lib = db.LibraryModels.Find(id);
            db.LibraryModels.Remove(lib);
            int i = db.SaveChanges();
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

    }
}