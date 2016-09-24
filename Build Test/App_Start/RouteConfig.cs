using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;


namespace Build_Test
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
        //public static void RegisterRoutes(RouteCollection routes)
        //{
        //    routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

        //    routes.MapRoute(
        //        name: "Default",
        //        url: "{controller}/{action}/{id}",
        //        defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
        //        namespaces: new[] { "MyNamespace.Controllers" }
        //    );
        //    routes.MapRoute(
        //        "Admin_default",
        //        "Admin/{controller}/{action}/{id}",
        //        new { action = "Index", id = UrlParameter.Optional },
        //        new[] { "MyNamespace.Areas.Admin.Controllers" }
        //    );
        //}

    }
}