using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TopLib.Models;

namespace TopLib.Controllers
{
    public class TopicsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            using (TopicsContext db = new TopicsContext())
            {
                var topic = db.Topic.ToList();


                return View(topic);
            }

        }
       [HttpGet]
        public IActionResult Insert()
        {

            return View();

        }
        [HttpPost]
        public IActionResult Insert(Topic topic)

        {


            if (ModelState.IsValid)
            {
                TopicsContext db = new TopicsContext();


                return RedirectToAction("Index");

            }

            return View(topic);
            

            
        }
      
    }
}