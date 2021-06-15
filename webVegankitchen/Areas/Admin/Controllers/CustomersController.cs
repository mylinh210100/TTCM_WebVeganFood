using DIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webVegankitchen.Areas.Admin.Controllers
{
    public class CustomersController : BaseController
    {
        // GET: Admin/Customers
        public ActionResult ViewCustomer(string search, int? page)
        {
            var model = new CustomersModel().ListAll(search, page);
            ViewBag.keyword = search;
            return View(model);
        }
    }
}