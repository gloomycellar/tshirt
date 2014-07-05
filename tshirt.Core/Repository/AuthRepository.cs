using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;
using System.Threading.Tasks;
using tshirt.Core.Entities.Auth;

namespace tshirt.Core.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private DbContext context;
        private UserManager<IdentityUser> userManager;

        public AuthRepository(IDbContext context)
        {
            this.context = (DbContext)context;
            userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(this.context));
        }

        public async Task<IdentityResult> RegisterUser(User user)
        {
            IdentityUser identityUser = new IdentityUser { UserName = user.UserName };
            IdentityResult result = await userManager.CreateAsync(identityUser, user.Password);

            return result;
        }

        public async Task<IdentityUser> FindUser(string userName, string password)
        {
            IdentityUser user = await userManager.FindAsync(userName, password);

            return user;
        }

        public void Dispose()
        {
            context.Dispose();
            userManager.Dispose();
        }
    }
}
