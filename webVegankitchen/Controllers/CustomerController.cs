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
        public ActionResult EditInfo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditInfo(int id)
        {

            return View();
        }
    }
}