using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelFirstApproach.Models
{
    public class RegisterModel
    {
        public int UserId { get; set; }
        [Required(ErrorMessage ="UserName Cannot be Empty")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password Cannot be Empty")]
        public string  Password { get; set; }
        [Compare("Password",ErrorMessage ="Password and Confirm Password Mismatch")]
        public string ConfirmPwd { get; set; }
        [DataType(DataType.EmailAddress,ErrorMessage ="Invalid Email Id")]
        public string Emaild { get; set; }
        [Range(12,40,ErrorMessage ="Age should be 12-40")]
        public int Age { get; set; }
        [StringLength(10,ErrorMessage ="Address should be 10 characters")]
        public string Address { get; set; }
    }
}