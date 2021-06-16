using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webVegankitchen.Models
{
    [Serializable]
    public class CartItem
    {
        public string IdProduct { get; set; }

        public string ProductName { get; set; }

        public int Amount { get; set; }

        public double Price { get; set; }

    }
}