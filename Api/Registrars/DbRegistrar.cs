using CwkSocial.Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace CwkSocial.Api.Registrars
{
    public class DbRegistrar : IWebApplicationBuilderRegistrar
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString(
                "ConnectionStrings:Default"
            );

            builder.Services.AddDbContext<DataContext>(cfg =>
            {
                cfg.UseSqlServer(connectionString);
            });
        }
    }
}
