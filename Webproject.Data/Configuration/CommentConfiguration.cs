using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webproject.Data.EntityModel;

namespace Webproject.Data.Configuration
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments");

            builder.HasKey(m => m.ComId);

            builder.Property(m => m.Content).IsRequired();
            builder.Property(m => m.Created).IsRequired();

            builder.HasMany(m => m.Replys).WithOne(m => m.Comment);
            builder.HasMany(m => m.Reactions).WithOne(m => m.Comment);
            builder.HasOne(m => m.Post).WithMany(m => m.Comments).HasForeignKey(m => m.PostId);
            builder.HasOne(m => m.User).WithMany(m => m.Comments).HasForeignKey(m => m.UserId);
        }
    }
}
