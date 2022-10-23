using Ninject.Modules;
using Ninject.Planning.Bindings;
using Northwind.Business.Abstract;
using Northwind.Business.Model;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Model;
using Northwind.DataAccess.Model.EntitiyFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.DependencyResolvers.Ninject
{
    class BussinesModule :NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>();
            Bind<IProductDal>().To<EfProductDal>();
            Bind<ICategoryService>().To<CategoryManager>();
            Bind<ICategoryDal>().To<EfCategoryDal>();


        }
    }
}
