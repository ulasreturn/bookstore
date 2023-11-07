using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Email).IsRequired();
        builder.HasIndex(x => x.Email).IsUnique();
        builder.Property(x => x.UserName).IsRequired();
        builder.HasIndex(x => x.UserName).IsUnique();
        builder.Property(x => x.UserSurname).IsRequired();
        builder.Property(x => x.PasswordHash).IsRequired();
        builder.Property(x => x.PasswordSalt).IsRequired();
        builder.Property(x => x.Country).IsRequired();
        builder.Property(x => x.City).IsRequired();
        builder.Property(x => x.Telephone).IsRequired();
        builder.Property(x => x.CreatedAt).IsRequired();
        builder.Property(x => x.IsDeleted).IsRequired();
        builder.Property(x => x.UserPhoto).IsRequired();
 
    //user favori önceden bookid idi
    builder.HasMany(f => f.Favourites)
               .WithOne(u => u.User)
               .HasForeignKey(f => f.UserId);

        //user yorum
        builder.HasMany(f => f.Comment)
               .WithOne(u => u.User)
               .HasForeignKey(f => f.UserId);
        //user sipariş
        builder.HasMany(f => f.Orders)
               .WithOne(u => u.User)
               .HasForeignKey(f => f.UserId);
        //user sepet
        builder.HasOne(f => f.Basket)
               .WithOne(u => u.User);
               
        //user satış
        builder.HasMany(f => f.Sale)
               .WithOne(u => u.User)
               .HasForeignKey(f => f.UserId);

        builder.HasMany(f => f.Address)
               .WithOne(u => u.User)
               .HasForeignKey(f => f.UserId);

        builder.HasMany(f => f.Books)
               .WithOne(u => u.User)
               .HasForeignKey(f => f.UserId);

          builder.HasMany(f => f.Comment)
               .WithOne(u => u.User)
               .HasForeignKey(f => f.UserId);

  }
}
