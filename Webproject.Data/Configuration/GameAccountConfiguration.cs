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
    public class GameAccountConfiguration : IEntityTypeConfiguration<GameAccount>
    {
        public void Configure(EntityTypeBuilder<GameAccount> builder)
        {
            builder.ToTable("GameAccount");

            builder.HasKey(m => m.AccId);

            builder.Property(m => m._Account).IsRequired();
            builder.Property(m => m._Password).IsRequired();
            builder.Property(m => m.Price).IsRequired();
            builder.Property(m => m.Description);

            builder.HasOne(m => m.Game).WithMany(m => m.Accounts).HasForeignKey(m => m.GameId);
        }
    }
}
