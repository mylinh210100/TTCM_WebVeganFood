using DIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webVegankitchen.Controllers
{
    public class DrinkController : Controller
    {
        // GET: Drink
        public ActionResult DrinkView(int page = 1, int pSz = 4)
        {
            var list = new DrinksModel();
            var model = list.ListDrink(page, pSz);
            return View(model);
        }

        public ActionResult DrinkDetail(string id, int page = 1, int pageSz = 4)
        {
            var drink = new DrinksModel().ViewDetail(id);
            ViewBag.otherdrink = new DrinksModel().ListOther(id, page, pageSz);
            return View(drink);
        }

    }
}