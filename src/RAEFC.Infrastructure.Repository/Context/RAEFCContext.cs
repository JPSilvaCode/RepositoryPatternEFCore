using Microsoft.EntityFrameworkCore;
using RAEFC.Domain.Models;
using RAEFC.Infrastructure.Repository.Mappings;

namespace RAEFC.Infrastructure.Repository.Context
{
    public class RAEFCContext : DbContext
    {
        public RAEFCContext(DbContextOptions<RAEFCContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}