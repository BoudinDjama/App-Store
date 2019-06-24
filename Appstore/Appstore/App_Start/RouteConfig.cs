using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Appstore
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
         // Le Path pour le home page 
            routes.MapRoute(
             name: "Today",
             url: "AppStore/Today",
             defaults: new { controller = "AppStore", action = "Today", id = UrlParameter.Optional }
         );

         // Le Path pour la categorie jeu 
            routes.MapRoute(
             name: "Games",
             url: "AppStore/Games",
             defaults: new { controller = "AppStore", action = "Games", id = UrlParameter.Optional }
         );
         // Le Path pour les applications
            routes.MapRoute(
             name: "Apps",
             url: "AppStore/Apps",
             defaults: new { controller = "AppStore", action = "Apps", id = UrlParameter.Optional }
         );
         // Le Path pour le Search Bar
            routes.MapRoute(
               name: "SearchRoute",
               url: "Applications/NewApp/{id}",
               defaults: new { controller = "Applications", action = "NewApp", id = UrlParameter.Optional }
           );

         // La Page principal, le Path par defaut
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "AppStore", action = "Today", id = UrlParameter.Optional }
            );
            
        }
    }
}
