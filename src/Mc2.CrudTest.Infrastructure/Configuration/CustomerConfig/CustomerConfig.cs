using Mc2.CrudTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mc2.CrudTest.Infrastructure.Configuration.CustomerConfig;

public class PriceConfig : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.Property(c => c.PhoneNumber)
            .HasMaxLength(20)
            .IsUnicode(false);

        builder.HasIndex(c => new { c.FirstName, c.LastName, c.DateOfBirth })
            .IsUnique();
        
        builder.HasIndex(c => new { c.Email})
            .IsUnique();
    }
}
