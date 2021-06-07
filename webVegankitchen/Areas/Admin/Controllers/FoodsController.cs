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
        public ActionResult FoodInsert(Food collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("FoodIndex");
                }
                return View(collection);
            }
            catch (Exception)
            {

                return View();
            }
            
        }
    }
}