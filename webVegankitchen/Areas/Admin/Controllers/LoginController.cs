
using DIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using webVegankitchen.Areas.Admin.Code;
using webVegankitchen.Areas.Admin.Model;

namespace webVegankitchen.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/LoginAd
        [HttpGet]
        public ActionResult LoginAd()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LoginAd(LoginModel model)
        {
            //var result = new Account().Login(model.UserName, model.PassWord);
            if (Membership.ValidateUser(model.UserName, model.PassWord) && ModelState.IsValid)
            {
                //SessionHelper.SetSession(new UserSession() { UserName = model.UserName });
                FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Username or Password is incorrect");
            }
            return View(model);
        }

    }
}