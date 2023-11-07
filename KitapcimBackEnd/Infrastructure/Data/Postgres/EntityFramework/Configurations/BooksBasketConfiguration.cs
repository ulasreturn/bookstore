using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class BooksBasketConfiguration : IEntityTypeConfiguration<BooksBasket>
    {

        public void Configure(EntityTypeBuilder<BooksBasket> builder)
        {
            builder.HasKey(f => f.BooksId);
            builder.HasKey(f => f.BasketId);
            builder.Property(f => f.BooksId).IsRequired();
            builder.Property(f => f.BasketId).IsRequired();

            builder.HasOne(f => f.Books)
          .WithMany(u => u.BooksBasket)
          .HasForeignKey(f => f.BooksId);

            builder.HasOne(f => f.Basket)
          .WithMany(u => u.BooksBasket)
          .HasForeignKey(f => f.BasketId);


        }
    }
}
