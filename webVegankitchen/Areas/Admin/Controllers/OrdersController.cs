using DIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webVegankitchen.Areas.Admin.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Admin/Orders
        public ActionResult ViewOrder()
        {
            var listorder = new OrdersModel();
            var model = listorder.ListAll();
            return View(model);
        }
    }
}