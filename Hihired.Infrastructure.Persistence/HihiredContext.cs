using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Hihired.Infrastructure.Persistence
{
    public class HihiredContext : DbContext
    {
        public HihiredContext(DbContextOptions<HihiredContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

    public class HihiredContextFactory : IDesignTimeDbContextFactory<HihiredContext>
    {
        public HihiredContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<HihiredContext>();
            optionsBuilder.UseMySql("Server=localhost;User Id=root;Password=admin123*;Database=hihired;Port=3306",
                builder => { builder.MigrationsHistoryTable("__efmigrationshistory"); });
            return new HihiredContext(optionsBuilder.Options);
        }
    }
}