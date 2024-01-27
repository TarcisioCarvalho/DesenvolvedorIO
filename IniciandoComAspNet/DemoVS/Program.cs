using PorBaixoDosPanos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseMiddleware<LogTempoMiddleware>();


app.MapGet("/", () => "Hello World!");



app.Run();
