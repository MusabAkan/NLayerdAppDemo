using Northwind.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Abstract
{
    //base yada impletasyonu olması için yapılmıştır.
    public interface IProductDal : IEntitiyRepository<Product>
    {
        
    }
}
