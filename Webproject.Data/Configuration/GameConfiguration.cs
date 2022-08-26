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
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.ToTable("Games");

            builder.HasKey(m => m.GameId);

            builder.Property(m => m.GameName).IsRequired().HasMaxLength(30);
            builder.Property(m => m.Created).IsRequired();
            builder.Property(m => m.ImageUrl);
            builder.Property(m => m.Description);

            builder.HasOne(m => m.Category).WithMany(m => m.Games).HasForeignKey(m => m.CateId);
        }
    }
}
