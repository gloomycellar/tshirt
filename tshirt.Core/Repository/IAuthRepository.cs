using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Threading.Tasks;
using tshirt.Api.ViewModels.Auth;

namespace tshirt.Core.Repository
{
    public interface IAuthRepository : IDisposable
    {
        Task<User> FindUser(string username, string password);
        Task<IdentityResult> RegisterUser(User user);
    }
}
