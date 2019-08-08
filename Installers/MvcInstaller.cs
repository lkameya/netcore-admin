using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace netcore_admin.Installers
{
    public class MvcInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMvc(options => { options.EnableEndpointRouting = false; }).SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0);

            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Admin API", Version = "v1" });
            });
        }
    }
}
