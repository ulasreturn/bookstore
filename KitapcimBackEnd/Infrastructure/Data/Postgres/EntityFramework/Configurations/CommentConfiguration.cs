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
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.CommentText);
            builder.Property(x => x.CommentDate);
            builder.Property(x => x.BooksId);

            
            //COMMENT kitaplar
            builder.HasOne(x => x.Books)
                .WithMany(u => u.Comment)
                .HasForeignKey(x => x.BooksId);

            //comment User
            builder.HasOne(x => x.User)
                .WithMany(u => u.Comment)
                .HasForeignKey(x => x.UserId);

        }
    }
}
