using DAO.Model;
using DIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webVegankitchen.Common;
using webVegankitchen.Models;

namespace webVegankitchen.Controllers
{
    public class SigninController : Controller
    {
        // GET: Signin
        [HttpGet]
        public ActionResult Signin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signin(Account model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserModel();
                int result = dao.Login(model.Username, Encryptor.MD5Hash(model.PassWo));

                if (result == 1)
                {
                    var user = dao.GetByName(model.Username);
                    var usession = new UserLoginModel();
                    usession.UserName = user.Username;

                    Session["username"] = usession;
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

            return View("Signin");
        }


        [HttpGet]
        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(Account acc)
        {
            if (ModelState.IsValid)
            {
                var user = new UserModel();
                var Md5Pass = Encryptor.MD5Hash(acc.PassWo);
                acc.PassWo = Md5Pass;
                var Md5confirmPass = Encryptor.MD5Hash(acc.ConfirmPass);
                acc.ConfirmPass = Md5confirmPass;
                if (user.GetByName(acc.Username) != null)
                {
                    ModelState.AddModelError("", "username has already exist! please change it!");
                }
                else
                {
                    if (acc.PassWo != acc.ConfirmPass)
                    {
                        ModelState.AddModelError("", "Your confirm password incorrect!");
                    }
                    else
                    {
                        long rs = user.InsertAcc(acc);
                        if (rs > 0)
                        {
                            Session["IDaccount"] = acc;
                            return RedirectToAction("InfoAcc", "Signin");
                        }
                        else
                        {
                            ModelState.AddModelError("", "Create fail!");
                        }
                    }
                    
                }
               
            }

            return View();
        }

        [HttpGet]
        public ActionResult InfoAcc()
        {
            return View();
        }



        [HttpPost]
        public ActionResult InfoAcc(Customer customer)
        {
            if (Session["IDaccount"] == null)
            {
                return View("Signup");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    var model = new CustomersModel();
                    long rs = model.Insert(customer);

                    if (rs > 0)
                    {
                        Session["newinfo"] = customer;
                        return RedirectToAction("Index", "HomeCustom");
                    }
                    else
                    {
                        ModelState.AddModelError("", "insert info fail!");
                    }
                }
            }
            
                return View();
        }
    }
}