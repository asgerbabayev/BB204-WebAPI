using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp2.Configurations.Common;
using WebApp2.Entities;

namespace WebApp2.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.BaseAuditableConfigure();
        builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
        builder.Property(x => x.Price).HasDefaultValue(0).HasColumnType("decimal(18,2)").IsRequired();
        builder.Property(x => x.Count).HasDefaultValue(0);
    }
}


public class UserConfiguration : IEntityTypeConfiguration<AppUser>
{
    public void Configure(EntityTypeBuilder<AppUser> builder)
    {
        builder.HasMany(x => x.Friends).WithOne(x => x.Friend).HasForeignKey(x => x.FriendId);
    }
}