using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace netcore_admin.Installers
{
    public interface IInstaller
    {
        void InstallServices(IServiceCollection services, IConfiguration configuration);
    }
}
