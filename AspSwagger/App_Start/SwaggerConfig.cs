using System.Web.Http;
using WebActivatorEx;
using AspSwagger;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace AspSwagger
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;
            GlobalConfiguration.Configuration
              .EnableSwagger(c => c.SingleApiVersion("v1", "Asp.net Mvc Swagger"))
              .EnableSwaggerUi();
        }
    }
}
