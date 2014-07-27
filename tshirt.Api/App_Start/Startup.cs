using AutoMapper;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;
using Owin;
using System;
using System.Web.Http;
using tshirt.Api.App_Start;
using tshirt.Api.ViewModels.Account;
using tshirt.Core.Entities.Account;
using tshirt.Core.Helpers;

[assembly: OwinStartup(typeof(tshirt.Api.Startup))]
namespace tshirt.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            ConfigureOAuth(app);
            WebApiConfig.Register(config);
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            app.UseNinjectMiddleware(() => DependencyResolver.Kernel).UseNinjectWebApi(config);

            CreateMappings();
        }

        public void ConfigureOAuth(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/api/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                Provider = new SimpleAuthorizationServerProvider()
            };

            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }

        public void CreateMappings()
        {
            Mapper.CreateMap<RegisterData, User>().ForMember(dest => dest.UserName, opt => opt.MapFrom(v => v.Email));
            Mapper.CreateMap<AddressDetailsData, AddressDetails>().ReverseMap();
            Mapper.CreateMap<User, UserData>().ReverseMap();
        }
    }
}