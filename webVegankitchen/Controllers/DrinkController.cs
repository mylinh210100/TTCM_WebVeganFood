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
        public ActionResult Drink()
        {
            return View();
        }

        public ActionResult DrinkDetail()
        {
            return View();
        }

        public ActionResult OrtherDrink()
        {
            return PartialView("_OrtherDrink");
        }

        public ActionResult DrinkCmt()
        {
            return PartialView("_CommentDrink");
        }    
    }
}