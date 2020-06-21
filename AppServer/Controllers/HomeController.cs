using AppServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppServer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        
        public Resources Resources()
        {
            ViewBag.Message = "Your contact page.";

            Resources resource = new Resources();
            resource.Name = "giannis";
            resource.Name = "pap";
            return resource;
        }
    }
}