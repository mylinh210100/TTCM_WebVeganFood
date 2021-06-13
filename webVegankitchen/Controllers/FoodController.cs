using DIO;
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
        public ActionResult FoodView(int page = 1, int pSz = 4)
        {
            var list = new FoodsModel();
            var model = list.ListFood(page, pSz);
            return View(model);
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