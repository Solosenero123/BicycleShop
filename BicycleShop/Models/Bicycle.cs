using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BicycleShop.Models
{
    public class Bicycle
    {
        public Bicycle(int id, string name, string type, double price, bool free)
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Price = price;
            this.Free = free;
        }

        public Bicycle()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        private string type;
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                if (value == "Шоссейный" || value == "Горный")
                    type = value;
                else
                    throw new Exception("Invalid bicycle type");
            }
        }
        private double price;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 0)
                    price = value;
                else
                    throw new Exception("Invalid bicycle price");
            }
        }
        private bool free;

        public bool Free {
            get
            {
                return free;
            }
            set
            {
                if (value == true || value == false)
                    free = value;
                else
                    throw new Exception("Не верный bool");
            }
        }


    }
}