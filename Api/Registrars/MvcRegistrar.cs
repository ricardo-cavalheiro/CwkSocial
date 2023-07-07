using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace CwkSocial.Api.Registrars
{
    public class MvcRegistrar : IWebApplicationBuilderRegistrar
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();

            // setup API versioning
            builder.Services.AddApiVersioning(cfg =>
            {
                cfg.DefaultApiVersion = new ApiVersion(1, 0);
                cfg.AssumeDefaultVersionWhenUnspecified = true;
                cfg.ReportApiVersions = true;
                cfg.ApiVersionReader = new UrlSegmentApiVersionReader();
            });

            // setup API versioning to get Swagger working
            builder.Services.AddVersionedApiExplorer(cfg =>
            {
                cfg.GroupNameFormat = "'v'VVV";
                cfg.SubstituteApiVersionInUrl = true;
            });

            builder.Services.AddEndpointsApiExplorer();
        }
    }
}
