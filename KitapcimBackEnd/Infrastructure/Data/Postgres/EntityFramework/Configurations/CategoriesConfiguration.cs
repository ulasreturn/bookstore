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
    public class CategoriesConfiguration : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id);
            builder.Property(c => c.CategoryName);

            //category kitap
            builder.HasMany(f => f.Books)
                 .WithMany(u => u.Categories)
                 .UsingEntity<BooksCategories>();

            //category kitapcategory gerekli olmayabilir
            builder.HasMany(f => f.BooksCategories)
           .WithOne(u => u.Categories)
           .HasForeignKey(f => f.CategoriesId);
        }

        
    }
}
