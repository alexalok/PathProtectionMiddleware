using Microsoft.AspNetCore.Builder;

namespace PathProtectionMiddleware
{
    public static class PathProtectionExtensions
    {
        public static IApplicationBuilder UsePathProtection(this IApplicationBuilder builder, PathProtectionOptions options)
        {
            return builder.UseMiddleware<PathProtectionMiddleware>(options);
        }
    }
}