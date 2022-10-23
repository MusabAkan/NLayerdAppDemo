using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.DependencyResolvers.Ninject
{
    public class InstanceFactory
    {
        public static T GetInstance<T>( /*NinjectModule module*/)
        {
            var kernel = new StandardKernel(/*module*/ new BussinesModule());
            return kernel.Get<T>();
        }
    }
}
