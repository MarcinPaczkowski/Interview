using Aplication.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Configuration
{
    public class ExceptionHandlingMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                context.Response.ContentType = "application/json";
                if (ex is ApiException apiException)
                    context.Response.StatusCode = (int)apiException.StatusCode;
                else
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                var json = JsonConvert.SerializeObject(new { ErrorMessage = ex.Message });
                await context.Response.WriteAsync(json);
            }
        }
    }
}
