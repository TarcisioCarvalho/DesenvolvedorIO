namespace PorBaixoDosPanos
{
    public class TemplateMiddleware
    {
        private readonly RequestDelegate _next;
        public TemplateMiddleware(RequestDelegate next) 
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            await _next(httpContext);
        }
    }
}
