using System.Net;
using System.Text.Json;

namespace BuberDinner.API.Middlewares;

public class ErrorHandlingMiddleware
{
    private readonly RequestDelegate next;

    public ErrorHandlingMiddleware(RequestDelegate next)
    {
        this.next = next;
    }

    public async Task Invoke(HttpContext context /* other dependencies */)
    {
        try
        {
            await next(context);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex);
        }
    }

    private static Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        var code = HttpStatusCode.InternalServerError; // 500 if unexpected

        if (exception is Exception) code = HttpStatusCode.NotFound;
        // else if (exception is MyUnauthorizedException) code = HttpStatusCode.Unauthorized;
        // else if (exception is MyException)             code = HttpStatusCode.BadRequest;

        var result = JsonSerializer.Serialize(new { error = "An error ocurred while processing your request" });
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)code;
        return context.Response.WriteAsync(result);
    }
}