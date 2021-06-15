using DIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webVegankitchen.Areas.Admin.Controllers
{
    public class AccountController : BaseController
    {
        // GET: Admin/Account
        public ActionResult AccIndex(string search, int? page)
        {
            var model = new UserModel().ListAccPaging(search, page);
            ViewBag.keyword = search;
            return View(model);
        }

    }
}