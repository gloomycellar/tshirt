﻿using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;
using Owin;
using System;
using System.Web.Http;
using tshirt.App_Start;
using tshirt.Core.Helpers;

[assembly: OwinStartup(typeof(tshirt.Startup))]
namespace tshirt
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            ConfigureOAuth(app);
            WebApiConfig.Register(config);
            app.UseNinjectMiddleware(() => DependencyResolver.Kernel).UseNinjectWebApi(config);
        }

        public void ConfigureOAuth(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                Provider = new SimpleAuthorizationServerProvider()
            };

            // Token Generation
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }
}