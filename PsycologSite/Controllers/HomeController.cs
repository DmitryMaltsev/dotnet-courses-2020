using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PsycologSite.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PsycologSite.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext db;

        public HomeController(ApplicationContext context)
        {
            db = context;
        }

        public IActionResult Main1()
        {
            return View();
        }

        public IActionResult Main2()
        {
            return View();
        }
        public IActionResult Main3()
        {
            return View();
        }
        public IActionResult Main4()
        {
            return View();
        }
        public IActionResult Main5()
        {
            return View();
        }
        public IActionResult Main6()
        {
            return View();
        }
        public IActionResult Main7()
        {
            return View();
        }
        public IActionResult Main8()
        {
            return View();
        }
        public IActionResult Main9()
        {
            return View();
        }
        public IActionResult Main10()
        {
            return View();
        }
        public IActionResult Main11()
        {
            return View();
        }
        public IActionResult Main12()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Main13()
        {
            ViewBag.Views = db.Reviews.ToList();
            return View() ;
        }  
        [HttpPost]
        public IActionResult Main13(Review review)
        {
            if (ModelState.IsValid)
            {
                db.Reviews.Add(review);
                db.SaveChanges();
                return RedirectToAction("Main13");
            }
            else
                return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
