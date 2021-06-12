using DIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webVegankitchen.Areas.Admin.Controllers
{
    public class OrdersController : BaseController
    {
        // GET: Admin/Orders
        public ActionResult ViewOrder(string search, int page = 1, int pageSz = 10)
        {
            var listorder = new OrdersModel();
            var model = listorder.ListAll(search, page, pageSz);
            return View(model);
        }
    }
}