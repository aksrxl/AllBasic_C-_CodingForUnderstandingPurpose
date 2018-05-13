using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using DependencyInjection.Contracts;
using DependencyInjection.DataAccess;

namespace DependencyInjection.HelperClass
{
    public class CustomDependencyResolver:IDependencyResolver
    {
        IKernel kernel;
        public CustomDependencyResolver()

       {
           kernel = new StandardKernel();
           ConfigureBinding();
        }

        public void ConfigureBinding()
        {
            kernel.Bind<IEmployeeRepository>().To<EmployeeRepository>();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
          return  kernel.GetAll(serviceType);
        }
    }
}