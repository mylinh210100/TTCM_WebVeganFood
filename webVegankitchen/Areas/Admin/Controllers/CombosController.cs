using DAO.Model;
using DIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace webVegankitchen.Areas.Admin.Controllers
{
    public class CombosController : BaseController
    {
        DBWebsite db = new DBWebsite();
        // GET: Admin/Combos
        public ActionResult ComboIndex(string search, int? page)
        {
            var model = new CombosModel().ListAll(search, page);
            ViewBag.keyword = search;
            return View(model);
        }

        [HttpGet]
        public ActionResult InsertCombos()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult InsertCombos(Combo combos)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var model = new CombosModel();
                    int rs = model.Insert(combos.IdCombo, combos.ComboName, combos.NumberOfPerson, combos.ImgCombo);

                    if (rs > 0)
                    {
                        return RedirectToAction("ComboIndex");
                    }
                    else
                    {
                        ModelState.AddModelError("", "insert fail!");
                    }
                    
                }
                return View(combos);
            }
            catch (Exception)
            {

                return View();
            }
        }

        [HttpGet]
        public ActionResult EditCombo(string id)
        {
            var combo = new CombosModel().ViewDetail(id);

            return View(combo);
        }

        [HttpPost]
        public ActionResult EditCombo(Combo combo)
        {
            if (ModelState.IsValid)
            {
                var model = new CombosModel();
                var rs = model.Update(combo);
                if (rs)
                {
                    return RedirectToAction("ComboIndex", "Combos");
                }
                else
                {
                    ModelState.AddModelError("", "Update fail!");
                }
            }
            return View("ComboIndex");
        }

        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Combo c = db.Comboes.Find(id);
            if (c == null)
            {
                return HttpNotFound();
            }
            return View(c);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Combo c = db.Comboes.Find(id);
            db.Comboes.Remove(c);
            db.SaveChanges();
            return RedirectToAction("ComboIndex");
        }


    }
}