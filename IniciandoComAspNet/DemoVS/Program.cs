using PorBaixoDosPanos;

var builder = WebApplication.CreateBuilder(args);
builder.AddSerilog();
var app = builder.Build();

app.UseLogTempo();


app.MapGet("/", () => "Hello World!");



app.Run();
