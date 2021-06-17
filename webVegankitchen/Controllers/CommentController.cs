using DIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webVegankitchen.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        [HttpGet]
        public ActionResult ViewComment()
        {
            
            return View();
        }

        //[HttpPost]
        //public ActionResult ViewComment()
        //{

        //}
    }
}