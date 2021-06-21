using DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO
{
    public class Statistics
    {
        private DBWebsite db = null;

        public Statistics()
        {
            db = new DBWebsite();
        }

        public double TotalRevenue()
        {
            double totalre = db.Orders.Sum(x => x.TotalCash);
            return totalre;
        }


        public double TotalwMonthYear(int month, int year)
        {
            var list = db.Orders.Where(x => x.Date.Value.Month == month &&
                                        x.Date.Value.Year == year);
            double t = 0;
            foreach (var item in list)
            {
                t += item.TotalCash;
            }
            return t;
        }

        public int TotalOrder()
        {
            int t = db.Orders.Count();
            return t;
        }

        public int TotalOrderwMY(int m, int y)
        {
            var list = db.Orders.Where(x => x.Date.Value.Month == m &&
                                        x.Date.Value.Year == y);
            int t = list.Count();
            return t;
        }


        public int TotalAccount()
        {
            int t = db.Accounts.Count();
            return t;
        }

        public double TotalCash()
        {
            double t = db.Foundations.Sum(x=>x.TotalCash);
            return t;
        }
    }
}
