using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace PathProtectionMiddleware
{
    public class PathProtectionMiddleware 
    {
        readonly RequestDelegate _next;
        readonly PathProtectionOptions _options;

        public PathProtectionMiddleware(RequestDelegate next, PathProtectionOptions options)
        {
            _next = next;
            _options = options;
        }

        public async Task InvokeAsync(HttpContext context, IAuthorizationService authorizationService)
        {
            if (context.Request.Path.StartsWithSegments(_options.PathStartsWith))
            {
                var isAuthorized = await authorizationService.AuthorizeAsync(context.User, null, _options.PolicyName);
                if (!isAuthorized.Succeeded)
                {
                    await context.ChallengeAsync();
                    return;
                }
            }

            await _next(context);
        }
    }
}