﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopThoiTrang.Areas.Shopper.Controllers
{
    public class HomeController : Controller
    {
        // GET: Shopper/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}