using Northwind.DataAccess.Abstract;
using Northwind.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Model.EntitiyFramework
{
    //bütün impletasyon solid eğitimi üzerinde geçilecektir.
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}
