using DIO;
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
        public ActionResult ViewComment(string search, int? page)
        {
            var model = new CommentsModel().ListAll(search, page);
            ViewBag.keyword = search;
            return View(model);
        }
    }
}