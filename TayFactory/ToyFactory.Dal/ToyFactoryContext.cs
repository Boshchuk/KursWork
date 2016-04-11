using System.Data.Entity;

namespace ToyFactory.Dal
{
    public class ToyFactoryContext : DbContext
    {
        public DbSet<Material> Materials { get; set; }
    }
}
