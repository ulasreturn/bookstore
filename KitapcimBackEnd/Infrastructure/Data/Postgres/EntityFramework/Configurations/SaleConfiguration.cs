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
    internal class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.PaymentMethod);
            builder.Property(x => x.SalesInfo);
            builder.Property(x => x.Buyer);

            //satıi user
            builder.HasOne(f => f.User)
               .WithMany(u => u.Sale)
               .HasForeignKey(f => f.UserId);

            //satıi kitap
          



        }
    }
}
