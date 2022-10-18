

using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Model.EntitiyFramework;
using Northwind.Entities.Model;
using System.Collections.Generic;

namespace Northwind.DataAccess.Model
{
    public class ProductManager : IProductService
    {
        //EfProductDal _productDal = new EfProductDal();
        //diğer operasyonlarda kullanılacağın için global kod bloğuna atandı Tabi _ başına koymayı da unutma
        //yanlız burası göstermelik kesinlikle yanlış bağımlı olduğu için
        // bunun yerine  aşağıdaki gibi yazılmalıdr

        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            // herhangi bir Model klasör altında entitiy ver yada nhibernte ver fark etmez herhangi birini ver 
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //Business code
            //dependenct normalde böyle işlem olmaz ama katmanları anlamak için bunu yapıyoruz
            return _productDal.GetAll();
        }
    }
}
