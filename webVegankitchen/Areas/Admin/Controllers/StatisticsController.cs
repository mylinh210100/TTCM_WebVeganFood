using DIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webVegankitchen.Areas.Admin.Controllers
{
    public class StatisticsController : Controller
    {
        // GET: Admin/Statistics
        public ActionResult Index()
        {
            double totalR = new Statistics().TotalRevenue();
            ViewBag.TotalRevenue = totalR;
            ViewBag.TotalOrder = new Statistics().TotalOrder();
            ViewBag.TotalAccount = new Statistics().TotalAccount();
            ViewBag.TotalCash = new Statistics().TotalCash();
            return View();
        }


    }
}