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
    app.UsePathProtection(new PathProtectionOptions
    {
        PathStartsWith = "/admin",
        PolicyName = "Staff"
    });
}

app.UseEndpoints(endpoints =>
{
	endpoints.MapControllers();
});
```

