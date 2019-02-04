using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab21.Models;
using lab21.DAL;

namespace lab21.Controllers
{
    public class HomeController : Controller
    {
        private readonly ShopContext _context = new ShopContext();
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

            if (ModelState.IsValid)
            {
                _context.Customer.Add(user);
                _context.SaveChanges();
                return View(user);
            }
            return View(user);
        }
    }
}

        