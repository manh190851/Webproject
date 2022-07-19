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
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUsers");

            builder.Property(m => m.fullname).IsRequired().HasMaxLength(100);

            builder.Property(m => m.gender).IsRequired();

            builder.Property(m => m.DOB).IsRequired();

            builder.Property(m => m.nation).IsRequired().HasMaxLength(50);

            builder.Property(m => m.city).IsRequired().HasMaxLength(50);

            builder.Property(m => m.imageUrl);
        }
    }
}
