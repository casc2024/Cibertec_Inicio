using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebDeveloper
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "RazorId",
            //    url: "Razor/{id}",
            //    defaults: new { controller = "Razor", action = "EntryId", id = UrlParameter.Optional }
            //);

            ////Ruteo personalizado
            ////Ruteo personalizado para usar una fecha como parametros de preferencia separar po guiones
            ////Razor/2016/12/12
            ////Razor/256/12/2016
            //routes.MapRoute(
            //    name: "RazorDate",
            //    url: "Razor/{date}",
            //    defaults: new { controller = "Razor", action = "EntryDate", id = UrlParameter.Optional }
            //);

            routes.MapMvcAttributeRoutes(); //para trabjar con los enrrutamientos definidos en el controlador

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Client", action = "Index", id = UrlParameter.Optional }
            );            

        }
    }
}
