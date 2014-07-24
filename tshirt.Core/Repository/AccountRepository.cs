using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;
using System.Threading.Tasks;
using tshirt.Core.Entities.Account;

namespace tshirt.Core.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private DbContext context;
        private UserManager<User> userManager;

        public AccountRepository(IDbContext context)
        {
            this.context = (DbContext)context;
            userManager = new UserManager<User>(new UserStore<User>(this.context));
        }

        public async Task<IdentityResult> RegisterUser(User user)
        {
            IdentityResult result = await userManager.CreateAsync(user, user.Password);

            return result;
        }

        public async Task<User> FindUser(string userName, string password)
        {
            User user = await userManager.FindAsync(userName, password);

            return user;
        }

        public async Task<User> FindUserByName(string userName)
        {
            User user = await userManager.FindByNameAsync(userName);

            return user;
        }

        public void Dispose()
        {
            context.Dispose();
            userManager.Dispose();
        }        
    }
}
