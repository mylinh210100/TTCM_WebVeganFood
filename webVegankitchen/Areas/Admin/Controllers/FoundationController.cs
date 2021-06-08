using DAO.Model;
using DIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webVegankitchen.Areas.Admin.Controllers
{
    public class FoundationController : BaseController
    {
        // GET: Admin/Foudation
        public ActionResult FoundationIndex()
        {
            var listF = new FoundationModel();
            var model = listF.ListAll();
            return View(model);
        }
    }
}