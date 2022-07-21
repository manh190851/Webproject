using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webproject.Data.EntityModel;
using Webproject.Data.Enum;

namespace Webproject.Data.Configuration
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Post");

            builder.HasKey(m => m.PostId);

            builder.Property(m => m.Title).IsRequired();
            builder.Property(m => m.Created).HasDefaultValue(DateTime.Now);
            builder.Property(m => m.Status).HasDefaultValue(PostStatus.Public);
            builder.Property(m => m.Url);
            builder.Property(m => m.IsDeleted).HasDefaultValue(false);
            builder.Property(m => m.ShareCount).HasDefaultValue(0);

            builder.HasMany(m => m.Comments).WithOne(m => m.Post);
            builder.HasMany(m => m.Reactions).WithOne(m => m.Post);
            builder.HasOne(m => m.User).WithMany(m => m.Posts).HasForeignKey(m => m.UserId);
            builder.HasMany(m => m.Shares).WithOne(m => m.Post);
        }
    }
}
