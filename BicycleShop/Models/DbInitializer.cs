using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BicycleShop.Models
{
    public class DbInitializer : CreateDatabaseIfNotExists<BicycleContext>
    {
        protected override void Seed(BicycleContext context)
        {

            context.Bicycles.Add(new Bicycle { Free = true, Name = "nice bicycle", Id = 0, Price = 20, Type = 0 });
            context.Bicycles.Add(new Bicycle { Free = false, Name = "bad bicycle", Id = 1, Price = 10, Type = 1 });
            base.Seed(context);
        }

    }
}