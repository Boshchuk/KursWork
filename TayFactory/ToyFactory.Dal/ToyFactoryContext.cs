using System.Data.Entity;

namespace ToyFactory.Dal
{
    public class ToyFactoryContext : DbContext
    {
        public DbSet<Material> Materials { get; set; }

        public DbSet<Toy> Toys { get; set; }

        public DbSet<Customer> Customers { get; set; } 
    }
}
