using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TopLib.Models;

namespace TopLib.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            using (TopicsContext db = new TopicsContext())
            {
                return View();
            }
               
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Register model)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Index","Topics");
            }
            return View();
        }


        public IActionResult AddTopics()
        {
            return View();
        }

        
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
