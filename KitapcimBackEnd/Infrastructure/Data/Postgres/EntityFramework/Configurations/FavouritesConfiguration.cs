using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class FavouritesConfiguration : IEntityTypeConfiguration<Favourites>
    {
        public void Configure(EntityTypeBuilder<Favourites> builder)
        {


          
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Id).IsRequired();
            builder.Property(f => f.BooksId).IsRequired();
            builder.Property(f => f.UserId).IsRequired();


            //favourite user
            builder.HasOne(f => f.User)
                .WithMany(u => u.Favourites)
                .HasForeignKey(f => f.UserId);

            //favourite book
            builder.HasOne(f => f.Books)
                .WithMany(u => u.Favourites)
                .HasForeignKey(f => f.BooksId);

        }
    }
}