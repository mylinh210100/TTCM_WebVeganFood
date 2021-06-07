using DAO.Model;
using DIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webVegankitchen.Areas.Admin.Controllers
{
    public class CombosController : Controller
    {
        // GET: Admin/Combos
        public ActionResult ComboIndex()
        {
            var listcombo = new CombosModel();
            var model = listcombo.ListAll();
            return View(model);
        }

        public ActionResult InsertCombos()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InsertCombos(Combo combos)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var model = new CombosModel();
                    int rs = model.Insert(combos.IdCombo, combos.ComboName, combos.ComboPrice, combos.NumberOfFoods,
                        combos.NumberOfDinks, combos.NumberOfPerson, combos.ImgCombo);

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
        


    }
}