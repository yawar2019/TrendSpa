using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC8amTigerBatch_09_07_2021.Models
{
    public class RegisterationModel
    {

        public int UserId { get; set; }
        [Required(ErrorMessage ="UserName Cannot be Empty")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password Cannot be Empty")]
        public string Password { get; set; }

        [Compare("Password",ErrorMessage ="Password and ConfirmPassword Mismatch")]
        public string ConfirmPassword { get; set; }

       [DataType(DataType.EmailAddress,ErrorMessage ="EmailId is Invalid")]
        public string EmailId { get; set; }
        [Range(18,45,ErrorMessage ="age between 18- 45 allowed")]
        public int Age { get; set; }

        [StringLength(10,ErrorMessage ="10 character allowed")]
        public string Address { get; set; }
    }
} 