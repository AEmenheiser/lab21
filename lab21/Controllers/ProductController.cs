﻿using lab21.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab21.Controllers
{
    public class ProductController : Controller
    {

        private ShopContext db = new ShopContext();
        // GET: Product
        public ActionResult Index()
        {


            return View(db.Item.ToList());

        }
    }
}