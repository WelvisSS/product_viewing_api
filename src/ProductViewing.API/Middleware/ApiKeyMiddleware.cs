public class ApiKeyMiddleware
{
    private const string HEADER_NAME = "X-API-KEY";
    private readonly RequestDelegate _next;
    private readonly string _expectedApiKey;

    public ApiKeyMiddleware(RequestDelegate next, IConfiguration config)
    {
        _next = next;
        _expectedApiKey = config["ApiKey"] ?? "default-key";
    }

    public async Task InvokeAsync(HttpContext context)
    {
        if (!context.Request.Headers.TryGetValue(HEADER_NAME, out var providedKey) || providedKey != _expectedApiKey)
        {
            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
            await context.Response.WriteAsync("Unauthorized");
            return;
        }

        await _next(context);
    }
}