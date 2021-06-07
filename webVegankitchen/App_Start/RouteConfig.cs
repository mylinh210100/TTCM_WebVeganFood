using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace webVegankitchen
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "HomeCustom", action = "Index", id = UrlParameter.Optional }
            );
            //signinpage
            routes.MapRoute(
               name: "Signin",
               url: "signin",
               defaults: new { controller = "Signin", action = "Signin" }
           );

            //Food page
            routes.MapRoute(
               name: "FoodView",
               url: "food",
               defaults: new { controller = "Food", action = "FoodView" }
           );

            //food detail
            routes.MapRoute(
               name: "FoodDetail",
               url: "fooddetail",
               defaults: new { controller = "Food", action = "FoodDetail" }
           );

            //drink page
            routes.MapRoute(
              name: "Drink",
              url: "drink",
              defaults: new { controller = "Drink", action = "Drink" }
          );
            //drink detail
            routes.MapRoute(
             name: "DrinkDetail",
             url: "drinkdetail",
             defaults: new { controller = "Drink", action = "DrinkDetail" }
         );
            //Combo page
            routes.MapRoute(
            name: "Combo",
            url: "combo",
            defaults: new { controller = "Combo", action = "Combo" }
        );
            //combo detail
            routes.MapRoute(
            name: "ComboDetail",
            url: "combodetail",
            defaults: new { controller = "Combo", action = "ComboDetail" }
        );



        }
    }
}
