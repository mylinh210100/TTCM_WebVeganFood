using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAO.ViewDetail
{
    public class OrderViewDetail
    {
        [Key]
        public int idOrder { get; set; }

        public int serial { get; set; }

        public string foodName { get; set; }

        public string drinkName { get; set; }

        public string comboName { get; set; }

        public int amount { get; set; }

        public double price { get; set; }





    }
}