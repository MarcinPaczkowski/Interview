using WebApi.Middlewares;

namespace WebApi.Configuration
{
    public static class DependencyInjection
    {
        public static void AddExceptionHandlingMiddleware(this IServiceCollection services)
        {
            services.AddTransient<ExceptionHandlingMiddleware>();
        }
    }
}
