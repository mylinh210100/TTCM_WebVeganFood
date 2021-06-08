using DAO.Model;
using DIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webVegankitchen.Areas.Admin.Controllers
{
    public class ComboDetailController : BaseController
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

        public void SetViewBag(string selectedId = null)
        {
            var dao = new ComboFoodModel();
            ViewBag.IdFood = new SelectList(dao.ListID(), "IdFood", "FoodName", selectedId);
        }

        [HttpGet]
        public ActionResult InsertComboFood()
        {
            SetViewBag();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult InsertComboFood(ComboFoodDetail detail)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var model = new ComboFoodModel();
                    string rs = model.Insert(detail);
                    if (!string.IsNullOrEmpty(rs))
                    {
                        return RedirectToAction("ComboFood");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Insert fail!");
                    }
                }
                return View(detail);
            }
            catch (Exception)
            {
                return View();
            }
        }

        public void SetViewBagd(string selectedId = null)
        {
            var dao = new ComboDrinkModel();
            ViewBag.IdDrink = new SelectList(dao.ListID(), "IdDrink", "DrinkName", selectedId);
        }
        [HttpGet]
        public ActionResult InsertComboDrink()
        {
            SetViewBagd();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult InsertComboDrink(ComboDrinkDetail detail)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var model = new ComboDrinkModel();
                    string rs = model.Insert(detail);
                    if (!string.IsNullOrEmpty(rs))
                    {
                        return RedirectToAction("ComboDrink");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Insert fail!");
                    }
                }
                return View(detail);
            }
            catch (Exception)
            {
                return View();
            }

        }

        //[HttpGet]
        //public ActionResult EditComboFood(string idc)
        //{
        //    var food = new ComboFoodModel().ViewDetail(idc);
        //    return View(food);
        //}

        //[HttpPost]
        //public ActionResult EditComboFood(ComboFoodDetail detail)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var model = new ComboFoodModel();
        //        var rs = model.Update(detail);
        //        if (rs)
        //        {
        //            return RedirectToAction("ComboFood", "ComboDetail");
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", "Update fail!");
        //        }
        //    }
        //    return View("ComboFood");
        //}

        //[HttpGet]
        //public ActionResult EditComboDrink(string idc)
        //{
        //    var food = new ComboDrinkModel().ViewDetail(idc);
        //    return View(food);
        //}

        //[HttpPost]
        //public ActionResult EditComboDrink(ComboDrinkDetail detail)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var model = new ComboDrinkModel();
        //        var rs = model.Update(detail);
        //        if (rs)
        //        {
        //            return RedirectToAction("ComboDrink", "ComboDetail");
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", "Update fail!");
        //        }
        //    }
        //    return View("ComboDrink");
        //}

    }
}