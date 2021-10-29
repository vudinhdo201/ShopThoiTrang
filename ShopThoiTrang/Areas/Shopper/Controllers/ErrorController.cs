using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopThoiTrang.Areas.Shopper.Controllers
{
    public class ErrorController : Controller
    {
        [HandleError]
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult NotFound()
        {
            Response.StatusCode = 404;
            return View();
        }
    }
}