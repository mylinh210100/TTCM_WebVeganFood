using DIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webVegankitchen.Controllers
{
    public class ComboController : Controller
    {
        // GET: Combo
        public ActionResult Combo(int page = 1, int pSz = 4)
        {
            var list = new CombosModel();
            var model = list.ListCombo(page, pSz);
            return View(model);
        }

        public ActionResult ComboDetail()
        {
            return View();
        }

        public ActionResult OrtherCombo()
        {
            return PartialView("_OrtherCombo");
        }
        public ActionResult CommentrCombo()
        {
            return PartialView("_CommentCombo");
        }


    }
}