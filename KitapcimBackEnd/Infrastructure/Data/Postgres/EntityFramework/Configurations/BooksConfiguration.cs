using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    internal class BooksConfiguration : IEntityTypeConfiguration<Books>
    {
        public void Configure(EntityTypeBuilder<Books> builder)
        {

            builder.HasKey(f => f.Id);
            builder.Property(f => f.Id).ValueGeneratedOnAdd();
            builder.Property(f => f.BookName).IsRequired();
            builder.Property(f => f.BookStatus).IsRequired();
            builder.Property(f => f.CoverPhoto).IsRequired();
            builder.Property(f => f.Price).IsRequired();
            builder.Property(f => f.Piece).IsRequired();
            builder.Property(f => f.Statement);


          //kitap kategori
           builder.HasMany(f => f.Categories)
                .WithMany(u => u.Books)
                .UsingEntity<BooksCategories>();


            //kitap sepet değiştirdim
            builder.HasMany(f => f.Basket)
                .WithMany(u => u.Books)
                .UsingEntity<BooksBasket>();

            //kitap satış burası bookıd
   
          
            //kitap user değiştirdim geri burası boookid 
            builder.HasOne(f => f.User)
                .WithMany(u => u.Books)
                .HasForeignKey(f => f.UserId); //bir kitaptan sadece birr tane var olarak düşünebiliriz
            //kitap yorum değiştirdim
            builder.HasMany(f => f.Comment)
                .WithOne(u => u.Books)
                .HasForeignKey(f => f.BooksId);
            //kitap favoriler
            builder.HasMany(f => f.Favourites)
                .WithOne(u => u.Books)
                .HasForeignKey(f => f.BooksId);

            //kitap kitapkategori burası gerekli olmayabilir
            builder.HasMany(f => f.BooksCategories)
            .WithOne(u => u.Books)
            .HasForeignKey(f => f.BooksId);

            //kitap kitapbasket burası gerekli olmayabilir
            builder.HasMany(f => f.BooksBasket)
           .WithOne(u => u.Books)
           .HasForeignKey(f => f.BooksId);
        }
    }
}
