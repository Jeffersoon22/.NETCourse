using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial_2.Services;

namespace Tutorial_2.Middleware
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IBrandService _brandService;

        public ErrorHandlingMiddleware(RequestDelegate next, IBrandService brandService)
        {
            _next = next;
            _brandService = brandService;
        }

        

        public async Task Invoke(HttpContext context)
        {
            try
            {
                context.Items.Add("Guid", _brandService.Guid);
                await _next(context);
            }
            catch (AccessDeniedException ex)
            {
                context.Response.StatusCode = 403;
                await context.Response.WriteAsync(ex.Message);
            }
            catch (PageNotFoundException ex)
            {
                context.Response.StatusCode = 404;
                await context.Response.WriteAsync(ex.Message);
            }
            catch (Exception ex)
            {
                await context.Response.WriteAsync("Ooops, something went wrong");
            }
        }
    }
}