using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WebApp2.Entities;

namespace WebApp2.DataAccess;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Product> Products { get; set; }

    public DbSet<AppUser> AppUser { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Product>().HasData(
        //    new Product { Id = 1, Name = "Test 1", Count = 12, Price = 5 },
        //    new Product { Id = 2, Name = "Test 2", Count = 12, Price = 5 },
        //    new Product { Id = 3, Name = "Test 3", Count = 12, Price = 5 }
        //    );
        modelBuilder.Entity<AppUser>().HasData(
            new AppUser { UserName = "nergiz", FriendId = "18b22b9e-0ab6-4365-b843-8c603bf88e5b", Email = "nergiz@code.edu.az" },
            new AppUser { UserName = "sitare", FriendId = "18b22b9e-0ab6-4365-b843-8c603bf88e5b", Email = "sitare@code.edu.az" }
        );
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}
