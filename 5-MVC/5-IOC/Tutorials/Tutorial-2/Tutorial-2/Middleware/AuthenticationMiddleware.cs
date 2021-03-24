using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial_2.Middleware
{
    public class AuthenticationMiddleware
    {
        private const string TokenKey = "token";
        private const string TokenValue = "2b74aca4-b3b9-454e-94d5-5f07eb3327fb";

        private readonly RequestDelegate _next;


        public AuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var tokenValue = context.Request.Query.FirstOrDefault(x => x.Key == TokenKey).Value;
            if (tokenValue == TokenValue)
            {
                await _next(context);
            }
            else
            {
                throw new AccessDeniedException();
            }

        }
    }
}
