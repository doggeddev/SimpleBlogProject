using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using SimpleBlogProject.Controllers;  //Had to import due to Admin Area PostsController conflicting with PostsController

namespace SimpleBlogProject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var namespaces = new[] {typeof(PostsController).Namespace};

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /*this matches the URL: ../login */ 
            routes.MapRoute("Login", "login", new {controller = "Auth", action = "Login"}, namespaces);

            
            routes.MapRoute("Home", "", new {controller = "Posts", action = "Index"}, namespaces);

        }
    }
}
