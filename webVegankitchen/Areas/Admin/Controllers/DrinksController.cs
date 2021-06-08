using DAO.Model;
using DIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webVegankitchen.Areas.Admin.Controllers
{
    public class DrinksController : BaseController
    {
        // GET: Admin/Drinks
        public ActionResult DrinkIndex(int page = 1, int pageSz = 5)
        {
            var listdrink = new DrinksModel();
            var model = listdrink.ListAll(page, pageSz);
            return View(model);
        }

        [HttpGet]
        public ActionResult InsertDrink()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult InsertDrink(Drink drink)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var model = new DrinksModel();
                    int rs = model.InsertDrink(drink.IdDrink, drink.DrinkName,
                        drink.DrinkPrice, drink.Drinkmaterial, drink.ImgDrink);
                    if (rs > 0)
                    {
                        return RedirectToAction("DrinkIndex");
                    }
                    else
                    {
                        ModelState.AddModelError("", "insert fail!");
                    }
                }
                return View(drink);
            }
            catch (Exception)
            {

                return View();
            }
        }

        [HttpGet]
        public ActionResult EditDrink(string id)
        {
            var drink = new DrinksModel().ViewDetail(id);

            return View(drink);
        }

        [HttpPost]
        public ActionResult EditDrink(Drink drink)
        {
            if (ModelState.IsValid)
            {
                var model = new DrinksModel();
                var rs = model.Update(drink);
                if (rs)
                {
                    return RedirectToAction("DrinkIndex", "Drinks");
                }
                else
                {
                    ModelState.AddModelError("", "Update fail!");
                }
            }
            return View("DrinkIndex");
        }

    }
}