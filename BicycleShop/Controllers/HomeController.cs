using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BicycleShop.Models;

namespace BicycleShop.Controllers
{
    public class HomeController : Controller
    {

        BicycleContext bicycleContext = new BicycleContext();  
        public ActionResult Index()
        {
            bicycleContext.Bicycles.Add(new Bicycle { Free = true, Name = "nice bicycle", Id = 0, Type = 0, Price = 20 });
            bicycleContext.Bicycles.Add(new Bicycle { Free = false, Name = "bad bicycle", Id = 1, Type = 1, Price = 10 });
            IEnumerable<Bicycle> bicycles = bicycleContext.Bicycles;
            
            ViewBag.Bicycles = bicycles;

            return View();
        }
    }
}