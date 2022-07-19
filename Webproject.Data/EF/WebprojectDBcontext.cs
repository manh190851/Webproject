using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webproject.Data.Configuration;
using Webproject.Data.EntityModel;

namespace Webproject.Data.EF
{
    public class WebprojectDBcontext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public WebprojectDBcontext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Fluent API
            builder.ApplyConfiguration(new AppUserConfiguration());
            builder.ApplyConfiguration(new AppRoleConfiguration());

            builder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            builder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(m => new {m.RoleId, m.UserId});
            builder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(m => m.UserId);
            builder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            builder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserToken").HasKey(m => m.UserId);
        }
    }
}
