var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async (context) =>
{
    await context.Response.WriteAsync($"Server local time: {DateTime.Now}");
});

app.MapGet("/ping", async (context) =>
{
    await context.Response.WriteAsync($"Server pong");
});

app.Run();
