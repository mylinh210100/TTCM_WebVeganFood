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
        public ActionResult ViewCustomer(string search, int page = 1, int pageSz = 10)
        {
            var listcus = new CustomersModel();
            var model = listcus.ListAll(search, page, pageSz);
            return View(model);
        }
    }
}