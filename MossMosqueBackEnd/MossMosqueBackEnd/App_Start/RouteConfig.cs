using MossMosqueBackEnd.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MossMosqueBackEnd
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


#if DEBUG
            // redirect localhost
            routes.MapRoute(
                name: "LocalhostRedirect",
                url: "",
                defaults: new { controller = "Home", action = "Index", path = "http://www.moss.namaz.no" },
                constraints: new
                {
                    subdomain = new SubdomainRouteConstraint("localhost")
                }
            );
#endif
        }
    }
}
