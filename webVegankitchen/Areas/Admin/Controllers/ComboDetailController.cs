using DIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webVegankitchen.Areas.Admin.Controllers
{
    public class ComboDetailController : Controller
    {
        // GET: Admin/ComboDetail
        public ActionResult ComboDrink()
        {
            var lcd = new ComboDrinkModel();
            var model = lcd.ListAll();
            return View(model);
        }

        public ActionResult ComboFood()
        {
            var list = new ComboFoodModel();
            var model = list.ListAll();
            return View(model);
        }
    }
}