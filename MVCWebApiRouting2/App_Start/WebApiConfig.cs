using MVCWebApiRouting2.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Routing;

namespace MVCWebApiRouting2
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var constraintResolver=new DefaultInlineConstraintResolver();
            constraintResolver.ConstraintMap.Add("ilkh",typeof(IlkHarf));//bu nesneyi maphttpattributesroutes içine koymamız lazım daha sonra ilkh diyerek kullanabilecegiz.

            // Web API routes
            config.MapHttpAttributeRoutes(constraintResolver);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
