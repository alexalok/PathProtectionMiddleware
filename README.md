![Nuget](https://img.shields.io/nuget/v/PathProtectionMiddleware)

# Installation

```c#
Install-Package PathProtectionMiddleware
```



# Sample usage

```c#
app.UseAuthentication();
app.UseAuthorization();

if (!env.IsDevelopment())
{
    app.UsePathProtection(opt => 
    {
        opt.PathStartsWith = "/admin"; // Mandatory
        opt.PolicyName = "Staff"; // Mandatory
        opt.AuthenticationSchemeName = CookieAuthenticationDefaults.AuthenticationScheme; // Optional
    });
}

app.UseEndpoints(endpoints =>
{
	endpoints.MapControllers();
});
```

