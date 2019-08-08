using netcore_admin.Domain;
using System.Threading.Tasks;

namespace netcore_admin.Services
{
    public interface IIdentityService
    {
        Task<AuthenticationResult> RegisterAsync(string email, string password);
    }
}
