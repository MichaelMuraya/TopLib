using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TopLib.Models;

namespace TopLib.Controllers
{
    public class AccountController : Controller
    {
        

        public IActionResult Login()
        {
            
            var login = new Login()
            {
               Name="Michael",
                Password="1234"
            };
            return View();
            //return RedirectToAction("AddTopics","Home", new { page = 1, sortBy = "name" });
        }
    }
}