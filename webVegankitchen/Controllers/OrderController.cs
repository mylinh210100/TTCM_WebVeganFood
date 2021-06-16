using DIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webVegankitchen.Models;

namespace webVegankitchen.Controllers
{
    public class OrderController : Controller
    {
        public const string cartsession = "Cartsession";

        // GET: Order
        [HttpGet]
        public ActionResult Order()
        {
            var idOrder = new OrdersModel().ViewID();
            Session["idOrder"] = idOrder;
            var cart = Session[cartsession];
            var list = new List<CartItem>();
            if (cart != null)
            {
                list = (List<CartItem>)cart;
            }
            return View(list);
        }

        public ActionResult AddItem(string id, string name, int amount, double price)
        {
            var cart = Session[cartsession];
            if (cart != null)
            {
                var list = (List<CartItem>)cart;
                if (list.Exists(l=>l.IdProduct == id))
                {
                    foreach (var item in list)
                    {
                        if (item.IdProduct == id)
                        {
                            item.Amount += amount;
                        }
                    }
                }
                else
                {
                    var item = new CartItem();
                    item.IdProduct = id;
                    item.ProductName = name;
                    item.Amount = amount;
                    item.Price = price;
                    list.Add(item);
                }
                Session[cartsession] = list;
            }
            else
            {
                var item = new CartItem();
                item.IdProduct = id;
                item.ProductName = name;
                item.Amount = amount;
                item.Price = price;
                var list = new List<CartItem>();
                list.Add(item);
                
                Session[cartsession] = list;
            }

            return RedirectToAction("Order");
        }

        public ActionResult OrderMenu()
        {
            return PartialView();
        }
    }
}