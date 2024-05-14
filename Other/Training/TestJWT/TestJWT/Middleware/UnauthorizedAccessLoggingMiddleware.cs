using Serilog;
using System.Security.Claims;

namespace TestJWT.Middleware;

public class UnauthorizedAccessLoggingMiddleware
{
    private readonly RequestDelegate _next;

    public UnauthorizedAccessLoggingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        await _next(context);

        if (context.Response.StatusCode == 403) 
        {
            //Assuming the user is registered
            var userEmail = context.User.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")?.Value;

            //TODO: Put which Permission is missing or soemthing like that
            Log.Warning($"Unauthorized access attempt by user: {userEmail}. Path: {context.Request.Path}");

        }
    }

}

public static class UnauthorizedAccessLoggingMiddlewareExtensions
{
    public static IApplicationBuilder UseUnauthorizedAccessLogging(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<UnauthorizedAccessLoggingMiddleware>();
    }
}