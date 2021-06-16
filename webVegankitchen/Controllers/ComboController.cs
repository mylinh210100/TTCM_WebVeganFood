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
        [HttpGet]
        public ActionResult Combo(string search, int? page)
        {
            var model = new CombosModel().ListAll(search, page);
            ViewBag.keyword = search;
            return View(model);
        }

        public ActionResult ComboDetail(string id, int page = 1, int pSz = 4)
        {
            var combo = new CombosModel().ViewDetail(id);
            ViewBag.othercombo = new CombosModel().ListOther(id, page, pSz);
            return View(combo);
        }




    }
}