using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace CodeFirstApproach.Models
{
    public class LibraryContext:DbContext
    {
        public LibraryContext():base("Constr")
        {

        }

        public DbSet<LibraryModel> LibraryModels { get; set; }
    }
}