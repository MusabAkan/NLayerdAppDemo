

using FluentValidation;
using Northwind.Business.Abstract;
using Northwind.Business.Ultilities;
using Northwind.Business.ValidationRules.FluentValidation;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Model.EntitiyFramework;
using Northwind.Entities.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;

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

        public void Add(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch (DbUpdateException e)
            {

                throw new Exception("Silme işlemi yapılamadı!!");
            }

        }

        public List<Product> GetAll()
        {
            //Business code
            //dependenct normalde böyle işlem olmaz ama katmanları anlamak için bunu yapıyoruz
            return _productDal.GetAll();
        }

        public List<Product> GetProductByCategory(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Product> GetProductByProductName(string productName)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
        }

        public void Update(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);

            _productDal.Update(product);
        }
    }
}
