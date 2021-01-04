using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
              => options.UseSqlite("Data Source=Skinet.db");

        public DbSet<Product> Products { get; set; }

    }

    //public class StoreFactory : IDesignTimeDbContextFactory<StoreContext>
    //{
    //    public StoreContext CreateDbContext(string[] args)
    //    {

    //        var optionsBuilder = new DbContextOptionsBuilder<StoreContext>();
    //        optionsBuilder.UseSqlite("your connection string");

    //        return new StoreContext(optionsBuilder.Options);
    //    }
    //}
}
