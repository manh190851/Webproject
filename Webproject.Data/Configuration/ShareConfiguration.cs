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
    public class ShareConfiguration : IEntityTypeConfiguration<Share>
    {
        public void Configure(EntityTypeBuilder<Share> builder)
        {
            builder.ToTable("Shares");

            builder.HasKey(m => m.ShareId);

            builder.Property(m => m.Title).IsRequired();
            builder.Property(m => m.Created);

            builder.HasOne(m => m.Users).WithMany(m => m.Shares).HasForeignKey(m => m.UserId);
            builder.HasOne(m => m.Post).WithMany(m => m.Shares).HasForeignKey(m => m.PostId).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
