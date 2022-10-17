

using Northwind.Entities.Model;
using System.Collections.Generic;

namespace Northwind.DataAccess.Model
{
    public class ProductManager
    {
        ProductDal _productDal = new ProductDal();//diğer operasyonlarda kullanılacağın için global kod bloğuna atandı Tabi _ başına koymayı da unutma
        public List<Product> GetAll()
        {
            //Business code
            //dependenct normalde böyle işlem olmaz ama katmanları anlamak için bunu yapıyoruz
            return _productDal.GetAll();
        }
    }
}
