using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAgency.Filter
{
    public class LoggedInAgent : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.Filters.OfType<NotLoggedIn>().Any())
            {
                return;
            }

            if (context.HttpContext.Session.GetInt32("agentid") == null)
            {
                context.HttpContext.Response.Redirect("/Agent/Index");
                return;
            }
            else
            {
                Controller controller = (Controller)context.Controller;
                controller.ViewBag.IsLoggedIn = true;
            }
        }
    }

}
