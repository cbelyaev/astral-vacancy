using System;
using System.Threading.Tasks;
using AstralVacancy.Common;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace AstralVacancy.WebApi.Infrastructure
{
    public class BusinessLogicErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public BusinessLogicErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next ?? throw new ArgumentNullException(nameof(next));
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (EntityNotFoundException ex)
            {
                context.Response.Clear();
                context.Response.StatusCode = StatusCodes.Status404NotFound;
                context.Response.ContentType = "application/json";

                var result = new
                {
                    Message = ex.UserFriendlyMessage,
                    Data = ex.BlErrorData
                };
                var serialized = JsonConvert.SerializeObject(result);
                await context.Response.WriteAsync(serialized);
            }
            catch (BusinessLogicException ex)
            {
                context.Response.Clear();
                context.Response.StatusCode = StatusCodes.Status422UnprocessableEntity;
                context.Response.ContentType = "application/json";

                var result = new
                {
                    Message = ex.UserFriendlyMessage,
                    Data = ex.BlErrorData
                };
                var serialized = JsonConvert.SerializeObject(result);
                await context.Response.WriteAsync(serialized);
            }
        }
    }
}