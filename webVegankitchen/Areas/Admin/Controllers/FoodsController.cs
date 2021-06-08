using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAO.Model;
using DIO;

namespace webVegankitchen.Areas.Admin.Controllers
{
    public class FoodsController : BaseController
    {
        // GET: Admin/Foods
        public ActionResult FoodIndex(int page = 1, int pageSz = 5)
        {
            var listfood = new FoodsModel();
            var model = listfood.ListAll(page, pageSz);
            return View(model);
        }
        [HttpGet]
        public ActionResult FoodInsert()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FoodInsert(Food foods)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var model = new FoodsModel();
                    int rs = model.Insert(foods.IdFood, foods.FoodName, 
                        foods.FoodPrice, foods.Foodmaterial, foods.ImgFood);

                    if (rs > 0)
                    {
                        return RedirectToAction("FoodIndex");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Insert fail!");
                    }
                }
                return View(foods);
            }
            catch (Exception)
            {
                return View();
            }
            
        }
        
        
        [HttpGet]
        public ActionResult EditFood(string id)
        {
            var food = new FoodsModel().ViewDetail(id);

            return View(food);
        }

        [HttpPost]
        public ActionResult EditFood(Food food)
        {
            if (ModelState.IsValid)
            {
                var model = new FoodsModel();
                var rs = model.Update(food);
                if (rs)
                {
                    return RedirectToAction("FoodIndex", "Foods");
                }
                else
                {
                    ModelState.AddModelError("", "Update fail!");
                }
            }
            return View("FoodIndex");
        }


    }
}