using Ninject;
using Ninject.Web.Common;
using System.Data.Entity;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using tshirt.App_Start;
using tshirt.Core.Repository;

namespace tshirt
{
    //public class WebApiApplication : NinjectHttpApplication
    //{
    //    protected override IKernel CreateKernel()
    //    {
    //        StandardKernel kernel = new StandardKernel();
    //        kernel.Load(Assembly.GetExecutingAssembly());

    //        kernel.Bind<IDbContext>().To<ApplicationDbContext>();
    //        kernel.Bind(typeof(IRepository<>)).To(typeof(Repository<>));

    //        GlobalConfiguration.Configuration.DependencyResolver = new LocalNinjectDependencyResolver(kernel);

    //        return kernel;
    //    }

    //    protected override void OnApplicationStarted()
    //    {
    //        base.OnApplicationStarted();

    //        Database.SetInitializer(new DatabaseInitializer());

    //        //AreaRegistration.RegisterAllAreas();
    //        GlobalConfiguration.Configure(WebApiConfig.Register);
    //        //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
    //        //RouteConfig.RegisterRoutes(RouteTable.Routes);
    //        //BundleConfig.RegisterBundles(BundleTable.Bundles);
    //    }


    //}
}
