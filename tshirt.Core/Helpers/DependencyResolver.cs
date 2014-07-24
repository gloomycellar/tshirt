using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using tshirt.Core.Repository;

namespace tshirt.Core.Helpers
{
    public static class DependencyResolver
    {
        private static IKernel kernel;

        static DependencyResolver()
        {
            kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            BindTypes();
        }

        public static IKernel Kernel { get { return kernel; } }

        public static T ResolveType<T>()
        {
            return Kernel.Get<T>();
        }

        private static void BindTypes() 
        {
            Kernel.Bind<IDbContext>().To<ApplicationDbContext>();
            Kernel.Bind(typeof(IRepository<>)).To(typeof(Repository<>));
            Kernel.Bind(typeof(IAccountRepository)).To(typeof(AccountRepository));
        }
    }
}
