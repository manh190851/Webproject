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
    public class ReplyConfiguration : IEntityTypeConfiguration<Reply>
    {
        public void Configure(EntityTypeBuilder<Reply> builder)
        {
            builder.ToTable("Replys");

            builder.HasKey(m => m.ReplyId);

            builder.Property(m => m.ReplyContent).IsRequired();
            builder.Property(m => m.Created).IsRequired();

            builder.HasMany(m => m.Reactions).WithOne(m => m.Reply);
            builder.HasOne(m => m.Comment).WithMany(m => m.Replys).HasForeignKey(m => m.ComId);
            builder.HasOne(m => m.User).WithMany(m => m.Replys).HasForeignKey(m => m.UserId);
        }
    }
}
