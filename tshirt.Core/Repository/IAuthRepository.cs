using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tshirt.Core.Entities.Auth;

namespace tshirt.Core.Repository
{
    public interface IAuthRepository : IDisposable
    {
        Task<IdentityUser> FindUser(string username, string password);
        Task<IdentityResult> RegisterUser(User user);
    }
}
