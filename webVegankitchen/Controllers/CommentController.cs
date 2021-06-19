using DAO.Model;
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
        DBWebsite db = new DBWebsite();
        // GET: Comment
        [HttpGet]
        public ActionResult Comment(int idorder)
        {
            var model = new OrdersModel().ViewDetailOrder(idorder);
            return PartialView(model);
        }

        [HttpPost]
        public ActionResult AddComment(FormCollection form)
        {
            try
            {
                var cmt = new Comment();
                cmt.IdProduct = string.Concat(form["idproduct"]);
                cmt.Comments = string.Concat(form["content"]);
                cmt.IdAcc = int.Parse(form["idacc"]);
                db.Comments.Add(cmt);
                db.SaveChanges();
                return RedirectToAction("CustomIndex", "HomeCustom");
            }
            catch (Exception)
            {

                return Content("ERROR Checkout. Please check your infomation!");
            }
        }

    }
}