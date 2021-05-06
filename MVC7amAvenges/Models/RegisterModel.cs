using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC7amAvenges.Models
{
    public class RegisterModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="UserName Cannot be Empty")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password Cannot be Empty")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Password and Confirm Password Mismatch")]
        public string ConfirmPassword { get; set; }
        [Range(20,40,ErrorMessage ="20-40 is Valid")]
        public int Age { get; set; }
        [DataType(DataType.EmailAddress,ErrorMessage ="Invalid Email Id")]
        public string EmailId { get; set; }
        [StringLength(20,ErrorMessage ="more then 20 characters not allowed")]
        public string Address { get; set; }
    }
}