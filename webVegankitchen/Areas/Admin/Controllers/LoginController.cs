using DAO.Model;
using DIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using webVegankitchen.Areas.Admin.Model;
using webVegankitchen.Common;

namespace webVegankitchen.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        DBWebsite db = new DBWebsite();
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
                int result = dao.Login(model.UserName, Encryptor.MD5Hash(model.PassWord));
                var acc = db.Accounts.SingleOrDefault(a => a.Username == model.UserName);
                if (result == 1)
                {

                    var listtp = db.TypePermissions.Where(t => t.IdType == acc.IdType);
                    string per = "";
                    foreach (var item in listtp)
                    {
                        per += item.Permission.IdPermission + ",";
                    }
                    per = per.Substring(0, per.Length - 1);
                    Permission(acc.Username, per);


                    var user = dao.GetByName(model.UserName);
                    var usession = new UserLogin();
                    usession.UserName = user.Username;
                    usession.Id = user.IdAcc;
                    Session.Add(ComConstants.USER_SESSION, usession);

                    return RedirectToAction("Index", "HomeAdmin");
                }
                else if (result == 0)
                {
                    ModelState.AddModelError("", "this account is not exist");
                }
                else if (result == -1)
                {
                    ModelState.AddModelError("", "your password is incorrect!");
                }
            }
            return View("Index");
           
        }

        public void Permission(string username, string permis)
        {
            FormsAuthentication.Initialize();
            var info = new FormsAuthenticationTicket(1,
                                               username,
                                               DateTime.Now, // time begin
                                               DateTime.Now.AddHours(4), //time out
                                               false,
                                               permis, //string permission
                                               FormsAuthentication.FormsCookiePath);
            var cookie = new HttpCookie(FormsAuthentication.FormsCookieName,
                                        FormsAuthentication.Encrypt(info));
            if (info.IsPersistent)
            {
                cookie.Expires = info.Expiration;
            }
            Response.Cookies.Add(cookie);
        }

    }
}