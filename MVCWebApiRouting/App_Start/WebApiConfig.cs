using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MVCWebApiRouting
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes(); //attributes based routing işlemleri için 

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}", //action based routing işlemleri için
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
