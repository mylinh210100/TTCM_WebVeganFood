﻿using DAO.Model;
using DIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace webVegankitchen.Areas.Admin.Controllers
{
    public class ComboDetailController : BaseController
    {
        DBWebsite db = new DBWebsite();
        // GET: Admin/ComboDetail
        public ActionResult ComboDrink(int page = 1, int pageSz = 5)
        {
            var list = new ComboDrinkModel();
            var model = list.ListAll(page, pageSz);
            return View(model);
        }

        public ActionResult ComboFood(int page = 1, int pageSz = 5)
        {
            var list = new ComboFoodModel();
            var model = list.ListAll(page, pageSz);
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

        public ActionResult Delete(string id, string idf)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComboFoodDetail comboFoodDetail = db.ComboFoodDetails.Where(c => c.IdCombo == id && c.IdFood == idf).SingleOrDefault();
            if (comboFoodDetail == null)
            {
                return HttpNotFound();
            }
            return View(comboFoodDetail);
        }

        // POST: Admin/ComboFoodDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ComboFoodDetail comboFoodDetail = db.ComboFoodDetails.Find(id);
            db.ComboFoodDetails.Remove(comboFoodDetail);
            db.SaveChanges();
            return RedirectToAction("ComboFood");
        }
    }
}