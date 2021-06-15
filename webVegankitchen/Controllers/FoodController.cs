using DAO.Model;
using DIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace webVegankitchen.Controllers
{
    public class FoodController : Controller
    {
        DBWebsite db = new DBWebsite();
        // GET: Food
        [HttpGet]
        public ActionResult FoodView(string search, int? page)
        {

            var model = new FoodsModel().ListFood(search, page);
            ViewBag.keyword = search;
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