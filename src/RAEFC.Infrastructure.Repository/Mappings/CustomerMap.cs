using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RAEFC.Domain.Models;

namespace RAEFC.Infrastructure.Repository.Mappings
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasColumnType("varchar(120)");

            builder.Property(c => c.Email)
                .IsRequired()
                .HasColumnType("varchar(120)");
        }
    }
}