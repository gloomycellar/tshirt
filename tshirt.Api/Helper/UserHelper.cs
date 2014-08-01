using System.Security.Claims;
using System.Threading.Tasks;
using tshirt.Core.Entities.Account;
using tshirt.Core.Helpers;
using tshirt.Core.Repository;

namespace tshirt.Api.Helper
{
    public static class UserHelper
    {
        public static User CurrentUser
        {
            get
            {
                string userName = ClaimsPrincipal.Current.FindFirst("sub").Value;
                return Task.Run(async () => await DependencyResolver.ResolveType<IAccountRepository>().FindUserByName(userName)).Result;
            }
        }
    }
}