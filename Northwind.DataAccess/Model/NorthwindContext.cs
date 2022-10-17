using Northwind.Entities.Model;
using System.Data.Entity;

namespace Northwind.DataAccess.Model
{
    public class NorthwindContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
