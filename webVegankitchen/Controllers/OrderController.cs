using DAO.Model;
using DIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webVegankitchen.Models;
using System.Web.Script.Serialization;

namespace webVegankitchen.Controllers
{
    public class OrderController : Controller
    {
        DBWebsite db = new DBWebsite();
        public const string cartsession = "Cartsession";
        // GET: Order
        [HttpGet]
        public ActionResult Order()
        {
            ViewBag.idFound = new OrdersModel().ListID(); 
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

        public JsonResult Update(string cartModel)
        {
            var jsoncart = new JavaScriptSerializer().Deserialize<List<CartItem>>(cartModel);
            var sessioncart = (List<CartItem>)Session[cartsession];

            foreach (var item in sessioncart)
            {
                var jsonitem = jsoncart.SingleOrDefault(x => x.IdProduct == item.IdProduct);
                if (jsonitem != null)
                {
                    item.Amount = jsonitem.Amount;
                }
            }
            Session[cartsession] = sessioncart;
            return Json(new
            {
                status = true
            });
        }


        public ActionResult AddItem(string id,  string name, int amount, double price)
        {
            var cart = Session[cartsession];
            if (cart != null)
            {
                var list = (List<CartItem>)cart;
                if (list.Exists(l => l.IdProduct == id))
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
                Session["cartcounter"] = list.Count;
            }
            
            return RedirectToAction("Order");
        }

        public ActionResult RemoveCart(string id)
        {
           var sscart = Session[cartsession];
            var list = (List<CartItem>)sscart;
            var p = list.FirstOrDefault(l => l.IdProduct == id);
            list.Remove(p);
            return RedirectToAction("Order");
        }

        public PartialViewResult OrderMenu()
        {
            var cart = Session[cartsession];
            var list = new List<CartItem>();
            if (cart != null)
            {
                list = (List<CartItem>)cart;
            }
            return PartialView(list);
        }

        public ActionResult Success()
        {

            return View();
        }

        public ActionResult CheckOut(FormCollection form)
        {
            try
            {
                var idOrder = new OrdersModel().ViewID();
                var sscart = Session[cartsession];
                var list = (List<CartItem>)sscart;
                //Foundation found = new Foundation();
                Order order = new Order();
                // add to order
                order.Date = DateTime.Now;
                order.IdCustomer = int.Parse(form["idCustomer"]);
                order.IdFoundation = int.Parse(form["idfound"]);
                order.SumOfProduct = list.Count;
                order.Discount = 0;
                order.TotalCash = float.Parse(form["totalpayment"]);
                db.Orders.Add(order);
                foreach (var item in list)
                {

                    OrderDetail detail = new OrderDetail();
                    detail.IdOrder = idOrder.IdOrder + 1;
                    if (db.Foods.SingleOrDefault(f=>f.IdFood == item.IdProduct) != null)
                    {
                        detail.IdFood = item.IdProduct;
                        detail.Amount = item.Amount;
                        detail.Price = item.Price;
                        detail.IntoMoney = item.Amount*item.Price;
                    }
                    else if (db.Drinks.SingleOrDefault(d=>d.IdDrink == item.IdProduct) != null)
                    {
                        detail.IdDrink = item.IdProduct;
                        detail.Amount = item.Amount;
                        detail.Price = item.Price;
                        detail.IntoMoney = item.Amount * item.Price;
                    }
                    else if (db.Comboes.SingleOrDefault(c=>c.IdCombo == item.IdProduct) != null)
                    {
                        detail.IdCombo = item.IdProduct;
                        detail.Amount = item.Amount;
                        detail.Price = item.Price;
                        detail.IntoMoney = item.Amount * item.Price;
                    }
                    db.OrderDetails.Add(detail);
                }
                db.SaveChanges();
                list.Clear();
                return RedirectToAction("Success", "Order");
            }
            catch (Exception)
            {
                return Content("ERROR Checkout. Please check your infomation!");
            }
        }
    }
}