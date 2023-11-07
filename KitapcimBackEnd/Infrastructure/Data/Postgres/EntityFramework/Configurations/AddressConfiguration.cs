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
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.City);
            builder.Property(x => x.Country);
            builder.Property(x => x.PostalCode);
            builder.Property(x => x.AddressText);
            builder.Property(x => x.AddressTitle);

            builder.HasOne(x => x.User)
                .WithMany(u => u.Address)
                .HasForeignKey(x => x.UserId);
        }
    }
}
