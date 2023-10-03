using EFCore.ProjectionOnNestedReference.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore.ProjectionOnNestedReference;

public class Context : DbContext
{
    public DbSet<Customer> Customers { get; set; }

    public DbSet<Company> Companies { get; set; }

    public DbSet<Country> Countries { get; set; }

    public string DbPath { get; }

    public Context()
    {
        DbPath = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "database.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite($"Data Source={DbPath}");
}