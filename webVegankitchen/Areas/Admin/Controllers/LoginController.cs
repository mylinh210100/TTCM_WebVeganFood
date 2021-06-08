using DIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webVegankitchen.Areas.Admin.Model;
using webVegankitchen.Common;

namespace webVegankitchen.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserModel();
                var result = dao.Login(model.UserName, Encryptor.MD5Hash( model.PassWord));

                if (result == 1)
                {
                    var user = dao.GetByName(model.UserName);
                    var usession = new UserLogin();
                    usession.UserName = user.Username;
                    usession.Id = user.IdAcc;
                    Session.Add(ComConstants.USER_SESSION, usession);

                    return RedirectToAction("Index", "HomeAdmin");
                }
                else if(result == 0)
                {
                    ModelState.AddModelError("", "this account is not exist");
                }
                else if(result == -1)
                {
                    ModelState.AddModelError("", "your password is incorrect!");
                }
            }
            return View("Index");
           
        }
    }
}