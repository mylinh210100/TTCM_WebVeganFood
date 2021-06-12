using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webVegankitchen.Controllers
{
    public class BaseClientController : Controller
    {
        // GET: BaseClient
        public ActionResult Index()
        {
            return View();
        }
    }
}