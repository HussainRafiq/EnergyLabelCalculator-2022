using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Linq;
using Microsoft.AspNetCore.Http;


namespace EnergyLabelCalculator
{
    public class UserFilterAttribute : Attribute,IAuthorizationFilter
    {
       
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!context.HttpContext.Session.Keys.Contains("UserID") || !context.HttpContext.Session.Keys.Contains("Role") || context.HttpContext.Session.GetString("Role")!="User")
            {
                context.Result = new RedirectToActionResult("Login", "Home", new { });
            }
           
        }
    }
}
