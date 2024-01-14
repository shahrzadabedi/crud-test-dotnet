using Mc2.CrudTest.Domain.Entities;
using Mc2.CrudTest.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Mc2.CrudTest.Infrastructure;

public  class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    private DbSet<Customer> Customer { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyAllConfigurations();
        base.OnModelCreating(modelBuilder);
    }
}

