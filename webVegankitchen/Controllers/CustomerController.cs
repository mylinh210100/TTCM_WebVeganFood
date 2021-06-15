using DAO.Model;
using DIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webVegankitchen.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        [HttpGet]
        public ActionResult ViewInfo(int id)
        {
            var model = new CustomersModel().ViewDetail(id);
            return View(model);
        }

        [HttpGet]
        public ActionResult EditInfo(int id)
        {
            var model = new CustomersModel().EditDetail(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult EditInfo(Customer customer)
        {
            if (ModelState.IsValid)
            {
                var model = new CustomersModel();
                var rs = model.Update(customer);
                if (rs)
                {
                    return RedirectToAction("CustomIndex", "HomeCustom");
                }
                else
                {
                    ModelState.AddModelError("", "Update fail!");
                }
            }
            return View("CustomIndex");
        }
    }
}