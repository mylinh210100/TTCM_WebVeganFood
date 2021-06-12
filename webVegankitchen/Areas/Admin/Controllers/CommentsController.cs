﻿using DIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webVegankitchen.Areas.Admin.Controllers
{
    public class CommentsController : BaseController
    {
        // GET: Admin/Comments
        public ActionResult ViewComment(string search, int page = 1, int pageSz = 10)
        {
            var listcmt = new CommentsModel();
            var model = listcmt.ListAll(search, page, pageSz);
            return View(model);
        }
    }
}