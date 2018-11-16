using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace AstralVacancy.WebApi.Infrastructure
{
    public class ErrorHandlingMiddleware
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly ILogger<ErrorHandlingMiddleware> _logger;
        private readonly RequestDelegate _next;

        public ErrorHandlingMiddleware(IHostingEnvironment hostingEnvironment, RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _hostingEnvironment = hostingEnvironment;
            _next = next ?? throw new ArgumentNullException(nameof(next));
            _logger = loggerFactory?.CreateLogger<ErrorHandlingMiddleware>()
                      ?? throw new ArgumentNullException(nameof(loggerFactory));
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, "Unhandled exception in application");

                if (context.Response.HasStarted)
                {
                    _logger.LogWarning("The response has already started, the http status code middleware will not be executed.");
                    throw;
                }

                context.Response.Clear();
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                context.Response.ContentType = "application/json";

                if (_hostingEnvironment.IsDevelopment())
                {
                    var result = new
                    {
                        ex.Message,
                        Stacktrace = ex.ToString()
                    };
                    var serialized = JsonConvert.SerializeObject(result);
                    await context.Response.WriteAsync(serialized);
                }
            }
        }
    }
}