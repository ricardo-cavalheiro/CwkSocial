using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace CwkSocial.Api.Registrars
{
    public class MvcWebAppRegistrar : IWebApplicationRegistrar
    {
        public void RegisterPipelineComponents(WebApplication app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(cfg =>
            {
                var provider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

                foreach (var description in provider.ApiVersionDescriptions)
                {
                    cfg.SwaggerEndpoint(
                        $"/swagger/{description.GroupName}/swagger.json",
                        description.ApiVersion.ToString()
                    );
                }
            });

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
