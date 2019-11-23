using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TopLib.Models
{
    public class Register
    {
        public string Name { get; set; }
       
        [Required(ErrorMessage = "Email is Required.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
       
        [Required(ErrorMessage = "Password is Required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password",ErrorMessage = "The Password and Confirm Password must match.")]
        [DataType(DataType.Password)]
        
        public string ConfirmPassword { get; set; }
    }
}
