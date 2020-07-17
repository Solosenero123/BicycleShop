using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BicycleShop.Models
{
    public class Bicycle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private int type;
        public int Type
        {
            get
            {
                return type;
            }
            set
            {
                if (value == 0 || value == 1)
                    type = value;
                else
                    throw new Exception("Invalid bicycle type");
            }
        }
        private int price;
        public int Price
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
        public bool Free { get; set; }

    }
}