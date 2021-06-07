using DIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webVegankitchen.Areas.Admin.Controllers
{
    public class CommentsController : Controller
    {
        // GET: Admin/Comments
        public ActionResult ViewComment()
        {
            var listcmt = new CommentsModel();
            var model = listcmt.ListAll();
            return View(model);
        }
    }
}