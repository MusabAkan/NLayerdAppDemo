using Northwind.Entities.Model;
using System.Data.Entity;

namespace Northwind.DataAccess.Model.EntitiyFramework
{
    public class NorthwindContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
