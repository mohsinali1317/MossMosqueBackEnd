using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace MossMosqueBackEnd.Helpers
{
    public class SubdomainRouteConstraint : IRouteConstraint
    {
        private readonly string _subdomain;

        public SubdomainRouteConstraint(string subdomain)
        {
            _subdomain = subdomain;
        }

        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            return httpContext.Request.Url != null && httpContext.Request.Url.Host.StartsWith(_subdomain);
        }
    }
}