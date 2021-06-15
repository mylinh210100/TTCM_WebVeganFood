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

            //sign out
               routes.MapRoute(
               name: "Sign Out",
               url: "sign-out",
               defaults: new { controller = "Signin", action = "Singout" },
               namespaces: new[] { "webVegankitchen.Controllers" }
           );


            //signinpage
            routes.MapRoute(
               name: "Sign In",
               url: "sign-in",
               defaults: new { controller = "Signin", action = "Signin" },
               namespaces: new[] { "webVegankitchen.Controllers" }
           );

            //Food page
            routes.MapRoute(
               name: "Food View",
               url: "food",
               defaults: new { controller = "Food", action = "FoodView" },
               namespaces: new[] { "webVegankitchen.Controllers" }
           );

            //food detail
            routes.MapRoute(
               name: "Food-Detail",
               url: "food-detail/{id}",
               defaults: new { controller = "Food", action = "FoodDetail" },
               namespaces: new[] { "webVegankitchen.Controllers" }
           );

            //drink page
            routes.MapRoute(
              name: "Drink",
              url: "drink",
              defaults: new { controller = "Drink", action = "DrinkView" },
              namespaces: new[] { "webVegankitchen.Controllers" }
          );
            //drink detail
            routes.MapRoute(
             name: "DrinkDetail",
             url: "drink-detail/{id}",
             defaults: new { controller = "Drink", action = "DrinkDetail" },
             namespaces: new[] { "webVegankitchen.Controllers" }
         );
            //Combo page
            routes.MapRoute(
            name: "Combo",
            url: "combo",
            defaults: new { controller = "Combo", action = "Combo" },
            namespaces: new[] { "webVegankitchen.Controllers" }
        );
            //combo detail
            routes.MapRoute(
            name: "ComboDetail",
            url: "combo-detail/{id}",
            defaults: new { controller = "Combo", action = "ComboDetail" },
            namespaces: new[] { "webVegankitchen.Controllers" }
        );
            //sign up
            routes.MapRoute(
            name: "SignUp",
            url: "sign-up",
            defaults: new { controller = "Signin", action = "Signup" },
            namespaces: new[] { "webVegankitchen.Controllers" }
        );
            //About us
            routes.MapRoute(
            name: "About us",
            url: "about-us",
            defaults: new { controller = "HomeCustom", action = "About" },
            namespaces: new[] { "webVegankitchen.Controllers" }
        );

            // contact us
            routes.MapRoute(
            name: "Contact us",
            url: "contact",
            defaults: new { controller = "HomeCustom", action = "Contact" },
            namespaces: new[] { "webVegankitchen.Controllers" }
        );

            //edit info customer
            routes.MapRoute(
            name: "Edit info customer",
            url: "edit-info/{id}",
            defaults: new { controller = "Customer", action = "EditInfo" },
            namespaces: new[] { "webVegankitchen.Controllers" }
        );
            //view info
            routes.MapRoute(
            name: "View info customer",
            url: "view-info/{id}",
            defaults: new { controller = "Customer", action = "ViewInfo" },
            namespaces: new[] { "webVegankitchen.Controllers" }
        );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "HomeCustom", action = "CustomIndex", id = UrlParameter.Optional },
                namespaces: new[] {"webVegankitchen.Controllers"}
            );



            


        }
    }
}
