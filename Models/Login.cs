using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TopLib.Models
{
    public class Login
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Name is Required.")]
        public string Name{ get; set; }
        [Required(ErrorMessage = "Email is Required.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Incorrect Name or Password.")]
        public string Password { get; set; }
       


    }
}
