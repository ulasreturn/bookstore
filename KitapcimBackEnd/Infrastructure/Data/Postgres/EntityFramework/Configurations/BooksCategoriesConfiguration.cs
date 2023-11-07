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
    public class BooksCategoriesConfiguration : IEntityTypeConfiguration<BooksCategories>
    {
        public void Configure(EntityTypeBuilder<BooksCategories> builder)
        {

            builder.Property(f => f.BooksId).IsRequired();
            builder.Property(f => f.CategoriesId).IsRequired();

            builder.HasOne(f => f.Books)
                .WithMany(u => u.BooksCategories)
                .HasForeignKey(f => f.BooksId);

            builder.HasOne(f => f.Categories)
                .WithMany(u => u.BooksCategories)
                .HasForeignKey(f => f.CategoriesId);
           
        }
    }
}
