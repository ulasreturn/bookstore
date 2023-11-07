using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class OrdersConfiguration : IEntityTypeConfiguration<Orders>
    {
        public void Configure(EntityTypeBuilder<Orders> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.OrderDate);
            builder.Property(x => x.PaymentMethod);
            builder.Property(x => x.AddressId);
            builder.Property(x => x.OrderPiece);
            builder.Property(x => x.UserId);

            //orders user
            builder.HasOne(f => f.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(f => f.UserId);
        }
    }
}
