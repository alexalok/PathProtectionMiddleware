using System;
using Microsoft.AspNetCore.Builder;

namespace PathProtectionMiddleware
{
    public static class PathProtectionExtensions
    {
        public static IApplicationBuilder UsePathProtection(this IApplicationBuilder builder, PathProtectionOptions options)
        {
            return builder.UseMiddleware<PathProtectionMiddleware>(options);
        }

        public static IApplicationBuilder UsePathProtection(this IApplicationBuilder builder,
            Action<PathProtectionOptions> configureOptions)
        {
            var options = new PathProtectionOptions();
            configureOptions(options);
            return builder.UseMiddleware<PathProtectionMiddleware>(options);
        }
    }
}