﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Oh_lala_Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Error",
            //    url: "Error/{action}",
            //    defaults: new { controller = "Error", action = "Index" }
            //);

            //routes.MapRoute(
            //    name: "Events",
            //    url: "{action}/{identifier}",
            //    defaults: new { controller = "Home", action = "Index", identifier = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}