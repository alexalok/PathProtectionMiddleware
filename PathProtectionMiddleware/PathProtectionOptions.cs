using Microsoft.AspNetCore.Http;

namespace PathProtectionMiddleware
{
    public class PathProtectionOptions
    {
        public PathString PathStartsWith { get; set; }

        public string PolicyName { get; set; } = null!;

        public string AuthenticationSchemeName { get; set; } = null!;
    }
}