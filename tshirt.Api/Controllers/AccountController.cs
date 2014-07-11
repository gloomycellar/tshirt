using AutoMapper;
using Microsoft.AspNet.Identity;
using System.Threading.Tasks;
using System.Web.Http;
using tshirt.Api.ViewModels.Auth;
using tshirt.Core.Repository;

namespace tshirt.Apiaccount.Controllers
{
    [RoutePrefix("api/Account")]
    public class AccountController : ApiController
    {
        private IAuthRepository repo;

        public AccountController(IAuthRepository repo)
        {
            this.repo = repo;
        }

        [AllowAnonymous]
        [Route("Register")]
        public async Task<IHttpActionResult> Register(RegisterData data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            User user = Mapper.Map<User>(data);
            IdentityResult result = await repo.RegisterUser(user);

            IHttpActionResult errorResult = GetErrorResult(result);

            if (errorResult != null)
            {
                return errorResult;
            }

            return Ok();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                repo.Dispose();
            }

            base.Dispose(disposing);
        }

        private IHttpActionResult GetErrorResult(IdentityResult result)
        {
            if (result == null)
            {
                return InternalServerError();
            }

            if (!result.Succeeded)
            {
                if (result.Errors != null)
                {
                    foreach (string error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }

                if (ModelState.IsValid)
                {
                    return BadRequest();
                }

                return BadRequest(ModelState);
            }

            return null;
        }
    }
}