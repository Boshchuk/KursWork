using System.Data.Entity;
using ToyFactory.Dal.Models;

namespace ToyFactory.Dal
{
    public class ToyFactoryContext : DbContext
    {
        public DbSet<Material> Materials { get; set; }

        public DbSet<Toy> Toys { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<StockItem> StockItems { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
