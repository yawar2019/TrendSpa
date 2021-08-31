﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace CodeFirstApproachPart2.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext():base("ConStr")
        {

        }

        public DbSet<EmployeeModel> EmployeeModels { get; set; }
    }
}