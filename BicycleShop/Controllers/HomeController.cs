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
        Bicycle lastbike;
        public ActionResult Index()
        {
            IEnumerable<Bicycle> bicycles = bicycleContext.Bicycles;
            ViewBag.Bicycles = bicycles;
            ViewBag.BicyclesCount = bicycles.Count();
            BikeId();
            return View();
        }


        [HttpPost]
        public ActionResult Bike(int id, string name, string type, bool free, double price)
        {       
            Bicycle bike = new Bicycle(id + 1, name, type, price, free);
            bicycleContext.Bicycles.Add(bike);
            BikeId();
            bicycleContext.SaveChanges();
            ViewBag.Bicycles = bicycleContext.Bicycles;
            return View("Index");
        }

        public ActionResult Bike(Bicycle bike)
        {           
            bicycleContext.Bicycles.Add(bike);
            BikeId();
            bicycleContext.SaveChanges();
            ViewBag.Bicycles = bicycleContext.Bicycles;
            return View("Index");
        }


        public ActionResult BikeDelete(int id)
        {
            Bicycle bike = bicycleContext.Bicycles.Find(id);
            bicycleContext.Bicycles.Remove(bike);
            BikeId();
            return View("Index");
        }

        [HttpPost]
        public ActionResult RentBike(int id)
        {
            Bicycle bike = bicycleContext.Bicycles.Find(id);
            bicycleContext.Bicycles.Remove(bike);
            bicycleContext.SaveChanges();
            bike.Free = false;
            Bike(bike);
            
            return View("Index");
        }

        [HttpPost]
        public ActionResult CancelRentBike(int id)
        {
            Bicycle bike = bicycleContext.Bicycles.Find(id);
            bicycleContext.Bicycles.Remove(bike);
            bicycleContext.SaveChanges();
            bike.Free = true;
            Bike(bike);
            return View("Index");
        }

        private void BikeId()
        {
            if (bicycleContext.Bicycles.Count() > 0)
            {
                IEnumerable<Bicycle> bicycles = bicycleContext.Bicycles;
                lastbike = bicycles.Last();
                ViewBag.BikeId = lastbike.Id;
            }
            else
                ViewBag.BikeId = 0;
        }
    }
}