using DIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webVegankitchen.Areas.Admin.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Admin/Customers
        public ActionResult ViewCustomer()
        {
            var listcus = new CustomersModel();
            var model = listcus.ListAll();
            return View(model);
        }
    }
}