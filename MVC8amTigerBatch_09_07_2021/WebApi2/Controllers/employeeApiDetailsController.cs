﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using WebApi2.Models;

namespace WebApi2.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class employeeApiDetailsController : ApiController
    {
        private EmployeeEntities db = new EmployeeEntities();

        // GET: api/employeeApiDetails
        public IQueryable<employeeDetail> GetemployeeDetails()
        {
            return db.employeeDetails;
        }

        // GET: api/employeeApiDetails/5
        [ResponseType(typeof(employeeDetail))]
        public IHttpActionResult GetemployeeDetail(int id)
        {
            employeeDetail employeeDetail = db.employeeDetails.Find(id);
            if (employeeDetail == null)
            {
                return NotFound();
            }

            return Ok(employeeDetail);
        }

        // PUT: api/employeeApiDetails/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutemployeeDetail(int id, employeeDetail employeeDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != employeeDetail.EmpId)
            {
                return BadRequest();
            }

            db.Entry(employeeDetail).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!employeeDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/employeeApiDetails
        [ResponseType(typeof(employeeDetail))]
        public IHttpActionResult PostemployeeDetail(employeeDetail employeeDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.employeeDetails.Add(employeeDetail);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = employeeDetail.EmpId }, employeeDetail);
        }

        // DELETE: api/employeeApiDetails/5
        [ResponseType(typeof(employeeDetail))]
        public IHttpActionResult DeleteemployeeDetail(int id)
        {
            employeeDetail employeeDetail = db.employeeDetails.Find(id);
            if (employeeDetail == null)
            {
                return NotFound();
            }

            db.employeeDetails.Remove(employeeDetail);
            db.SaveChanges();

            return Ok(employeeDetail);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool employeeDetailExists(int id)
        {
            return db.employeeDetails.Count(e => e.EmpId == id) > 0;
        }
    }
}