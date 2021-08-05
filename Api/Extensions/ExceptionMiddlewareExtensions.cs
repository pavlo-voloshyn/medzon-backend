
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Net;

namespace Api.Extensions
{
    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    
                    if (contextFeature != null)
                    {
                        HttpStatusCode statusCode;
                        var exception = contextFeature.Error;

                        if (exception is ArgumentException)
                        {
                            statusCode = HttpStatusCode.BadRequest;
                        }
                        else if (exception is ArgumentNullException)
                        {
                            statusCode = HttpStatusCode.NotFound;
                        }
                        else if (exception is InvalidOperationException)
                        {
                            statusCode = HttpStatusCode.MethodNotAllowed;
                        }
                        else
                        {
                            statusCode = HttpStatusCode.InternalServerError;
                        }
                        context.Response.StatusCode = (int)statusCode;
                        context.Response.ContentType = "application/json";
                        string result = JsonConvert.SerializeObject(exception);
                        await context.Response.WriteAsync(result);
                    }
                });
            });
        }
    }
}