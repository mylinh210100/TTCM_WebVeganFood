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

        [HttpGet]
        public ActionResult FoodDetail(string id, int page = 1, int pSz = 4)
        {
            var food = new FoodsModel().ViewDetail(id);
            ViewBag.OtherFood = new FoodsModel().ListOther(id, page, pSz);
            return View(food);
        }


    }
}