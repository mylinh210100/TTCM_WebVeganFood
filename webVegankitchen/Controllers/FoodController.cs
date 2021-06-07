using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webVegankitchen.Controllers
{
    public class FoodController : Controller
    {
        // GET: Food
        public ActionResult FoodView()
        {
            return View();
        }

        public ActionResult FoodDetail()
        {
            return View();
        }

        public ActionResult OrtherFood()
        {
            return PartialView("_OrtherFood");
        }

        public ActionResult FoodCmt()
        {
            return PartialView("_CommentFood");
        }
    }
}