using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApiDemo {
    public static class WebApiConfig {
        public static void Register(HttpConfiguration config) {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi", 
                //routeTemplate: "api/ctrl-{controller}/do-{action}/{id}",
                //routeTemplate: "api/{controller}/{action}/{id}",
                routeTemplate: "api/{controller}/{id}",
                //routeTemplate: "api/{action}/{id}", //<--This route will not work!

                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
