using DAO.Model;
using DIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webVegankitchen.Controllers
{
    public class HomeCustomController : Controller
    {
        [HttpGet]
        public ActionResult CustomIndex()
        {
            var model = new FoodsModel();
            var food = model.Top();
            return View(food);
        }

        [HttpGet]
        public ActionResult Drink()
        {
            var model = new DrinksModel();
            var drink = model.Top();
            return PartialView("Drink", drink);
        }

        [HttpGet]
        public ActionResult ComboTop()
        {
            var model = new CombosModel();
            var combo = model.Top();
            return PartialView("ComboTop", combo);
        }

        [HttpGet]
        public ActionResult About()
        {
            var model = new FoundationModel();
            var f = model.List();
            return View(f);
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult LoginMenu()
        {
            return PartialView("LoginMenu");
        }
    }
}