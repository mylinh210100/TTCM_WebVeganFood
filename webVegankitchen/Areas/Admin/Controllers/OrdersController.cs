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
        public ActionResult ViewOrder(string search, int? page)
        {
            var model = new OrdersModel().ListAll(search, page);
            ViewBag.keyword = search;
            return View(model);
        }

        public ActionResult OrderDetail(int id)
        {
            var model = new OrdersModel().ViewDetailOrder(id);
            return View(model);
        }
    }
}