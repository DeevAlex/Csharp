using APICatalogo.Models;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;
// devemos incluir as referencias à cima

namespace APICatalogo.Extensions;

// essa classe tem que ser estatica
public static class ApiExtensionMiddlewareExtensions
{

    // o this referece que esse metodo é um metodo de extensão para essa interface e estamos representando isso por essa instancia app
    public static void ConfigureExceptionHandler(this IApplicationBuilder app)
    {

        // estamos usando middleware 
        app.UseExceptionHandler(appError => 
        {

            // e estamos usando o metodo Run() para fazer o tratamento de exceção global definido para exibir as informações sobre o erro que ocorrer
            appError.Run(async context =>
            {
                  
                context.Response.StatusCode = (int) HttpStatusCode.InternalServerError;
                context.Response.ContentType = "application/json";

                var contextFeature = context.Features.Get<IExceptionHandlerFeature>();

                if (contextFeature != null)
                {

                    await context.Response.WriteAsync(new ErrorDetails()
                    {
                        StatusCode = context.Response.StatusCode,
                        Message = contextFeature.Error.Message,
                        Trace = contextFeature.Error.StackTrace
                    }.ToString());

                }

            });

        });

    }

}
