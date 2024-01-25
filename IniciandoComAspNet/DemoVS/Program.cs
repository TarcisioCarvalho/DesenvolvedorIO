var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/teste", () => "Test&¨%#@!");
app.MapGet("/teste/Jsx", () => "Test&¨%#@!");


app.Run();
