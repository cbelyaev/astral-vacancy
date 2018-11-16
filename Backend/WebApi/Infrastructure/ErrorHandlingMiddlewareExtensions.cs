using Microsoft.AspNetCore.Builder;

namespace AstralVacancy.WebApi.Infrastructure
{
    public static class ErrorHandlingMiddlewareExtensions
    {
        public static IApplicationBuilder UseErrorHandlingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ErrorHandlingMiddleware>()
                .UseMiddleware<BusinessLogicErrorHandlingMiddleware>();
        }
    }
}