using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab21.Models;

namespace lab21.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }



        [HttpGet]
        public ActionResult Register()
        {
            var user = new RegisterClass();

            if (ModelState.IsValid)
            {

                return View(user);
            }
            
            return View();
        }

        [HttpPost]
        public ActionResult Success(RegisterClass user)
        {
            return View(user);
        }
    }
}

        