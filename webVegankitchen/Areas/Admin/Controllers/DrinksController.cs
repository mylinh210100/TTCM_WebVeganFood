using DAO.Model;
using DIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webVegankitchen.Areas.Admin.Controllers
{
    public class DrinksController : Controller
    {
        // GET: Admin/Drinks
        public ActionResult DrinkIndex()
        {
            var listdrink = new DrinksModel();
            var model = listdrink.ListAll();
            return View(model);
        }

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




    }
}