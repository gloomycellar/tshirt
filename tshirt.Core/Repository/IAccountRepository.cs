using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Threading.Tasks;
using tshirt.Core.Entities.Account;

namespace tshirt.Core.Repository
{
    public interface IAccountRepository : IDisposable
    {
        Task<User> FindUser(string username, string password);
        Task<IdentityResult> RegisterUser(User user);
        Task<User> FindUserByName(string userName);
    }
}
