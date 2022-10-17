using Northwind.Entities.Model;
using System.Collections.Generic;
using System.Linq;

namespace Northwind.DataAccess.Model
{
    public class ProductDal
    {

        public List<Product> GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.ToList();
            }
        }
        public Product Get(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.SingleOrDefault(i=>i.ProductId == id);
            }
        }
        public void Add(Product products)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Add(products);
                context.SaveChanges();
            }
        }
        public void Update(Product products)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Add(products);
                context.SaveChanges();
            }
        }
        public void Delete(Product products)
        {

        }
    }
}
