using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class BasketConfiguration : IEntityTypeConfiguration<Basket>
    {
        public void Configure(EntityTypeBuilder<Basket> builder)
        {



            builder.HasKey(f => f.Id);
            builder.Property(f => f.Id).IsRequired();
            builder.Property(f => f.TotalPrice).IsRequired();
            builder.Property(f => f.Piece).IsRequired();


            //Basket book değiştirdim
            builder.HasMany(f => f.Books)
            .WithMany(u => u.Basket)
            .UsingEntity<BooksBasket>();

            //araştır bu kısım gerekli olmayabilir
            builder.HasMany(f => f.BooksBasket)
           .WithOne(u => u.Basket)
           .HasForeignKey(f => f.BasketId);

            //basket user
            builder.HasOne(f => f.User)
                .WithOne(u => u.Basket)
                .HasForeignKey<Basket>(f => f.UserId);



        }
    }
}
