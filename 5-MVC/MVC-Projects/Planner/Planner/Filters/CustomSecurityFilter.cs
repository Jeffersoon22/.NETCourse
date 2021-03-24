using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Planner.Helpers;
using Planner.Services;
using System.Linq;

namespace Planner.Filters
{
    public class CustomSecurityFilter : IResourceFilter
    {
        private readonly IAuthService _authService;

        public CustomSecurityFilter(IAuthService authService)
        {
            _authService = authService;
        }


        public void OnResourceExecuted(ResourceExecutedContext context)
        {

        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            if (!context.HttpContext.Request.Path.Value.Contains("Login"))
            {
                var token = string.Empty;
                var cookieExists = context.HttpContext
                    .Request
                    .Cookies
                    .Any(x => x.Key == Constants.tokenKey);
                if (cookieExists)
                {
                    token = context.HttpContext.Request.Cookies
                        .FirstOrDefault(x => x.Key == Constants.tokenKey).Value;
                    if (string.IsNullOrWhiteSpace(token) || !_authService.IsTokenValid(token))
                    {
                        context.Result = new RedirectResult("/Login/Index");
                    }
                }
                else context.Result = new RedirectResult("/Login/Index");
            }
        }
    }
}
