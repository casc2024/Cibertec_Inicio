using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebDeveloper.ActionFilters
{
    public class LogActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //var controllerName = filterContext.RouteData.Values["controller"]; //que controlador lo esta ejecutando
            //var actionName = filterContext.RouteData.Values["action"];
            //var message = $"OnActionExecuting controller : {controllerName} action: {actionName}";
            //Debug.WriteLine(message, "Action Filter Log");
            ResultDebug("OnActionExecuting", filterContext.RouteData);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //Debug.WriteLine($"OnActionExecuted controller : {filterContext.RouteData.Values["controller"]} action: {filterContext.RouteData.Values["action"]}", "Action Filter Log");            
            //Debug.WriteLine(ResultDebug("OnActionExecuted", filterContext.RouteData), "Action Filter Log");
            ResultDebug("OnActionExecuted", filterContext.RouteData);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            //Debug.WriteLine($"OnResultExecuted controller : {filterContext.RouteData.Values["controller"]} action: {filterContext.RouteData.Values["action"]}", "Action Filter Log");            
            //Debug.WriteLine(ResultDebug("OnResultExecuted", filterContext.RouteData), "Action Filter Log");
            ResultDebug("ResultExecutedContext", filterContext.RouteData);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            //Debug.WriteLine($"OnResultExecuting controller : {filterContext.RouteData.Values["controller"]} action: {filterContext.RouteData.Values["action"]}", "Action Filter Log");
            //Debug.WriteLine( ResultDebug("OnResultExecuting", filterContext.RouteData), "Action Filter Log");
            ResultDebug("ResultExecutingContext", filterContext.RouteData);
        }

        private static void ResultDebug(string nameResult, RouteData routeData)
        {
            //return $"{nameResult} controller : {routeData.Values["controller"]} action: {routeData.Values["action"]}";
            Debug.WriteLine( $"{nameResult} controller : {routeData.Values["controller"]} action: {routeData.Values["action"]}", "Action Filter Log");
        }
    }
}
