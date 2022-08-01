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
    public class AccountImageConfiguration : IEntityTypeConfiguration<AccountImage>
    {
        public void Configure(EntityTypeBuilder<AccountImage> builder)
        {
            builder.ToTable("AccountImage");    

            builder.HasKey(x => x.Id);

            builder.Property(m => m.Url).IsRequired();
            builder.Property(m => m.Type).IsRequired();

            builder.HasOne(m => m.Account).WithMany(m => m.Images).HasForeignKey(m => m.AccId);

        }
    }
}
