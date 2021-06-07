using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAO.Model;
using DIO;

namespace webVegankitchen.Areas.Admin.Controllers
{
    public class FoodsController : Controller
    {
        // GET: Admin/Foods
        public ActionResult FoodIndex()
        {
            var listfood = new FoodsModel();
            var model = listfood.ListAll();
            return View(model);
        }
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



    }
}