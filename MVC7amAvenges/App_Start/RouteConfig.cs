using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC7amAvenges
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
       

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default1",
                url: "pisstaHouse/pizza",
                defaults: new { controller = "new", action = "helloWorld", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );
        }
    }
}
