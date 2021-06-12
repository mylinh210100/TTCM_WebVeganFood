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
        public ActionResult AccIndex(string search, int page = 1, int pageSize = 10)
        {
            var listacc = new UserModel();
            var model = listacc.ListAccPaging(search, page, pageSize);
            return View(model);
        }

    }
}