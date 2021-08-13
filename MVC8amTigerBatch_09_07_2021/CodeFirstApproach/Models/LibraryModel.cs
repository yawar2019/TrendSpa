using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstApproach.Models
{
    public class LibraryModel
    {
        [Key]
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int Price { get; set; }
        public string Author { get; set; }
        public bool isAvailabel { get; set; }
    }
}