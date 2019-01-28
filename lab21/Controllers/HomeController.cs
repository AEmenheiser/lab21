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

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterClass NewPerson)
        {

            if (ModelState.IsValid)
            {
                ViewBag.Name = $"Thanks for signing up {NewPerson.FirstName} {NewPerson.LastName}!!!";
                return View("Success");
            }
            else
            {
                ViewBag.Error = "Oops! Try Again!";
                return View();
            }

           
        }

        public ActionResult Success()
        {
            return View();
        }
    }
}

        