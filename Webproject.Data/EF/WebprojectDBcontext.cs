﻿using Microsoft.AspNetCore.Identity;
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

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Reaction> Reactions { get; set; }
        public DbSet<Reply> Replies { get; set; }
        public DbSet<Share> Shares { get; set; }

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

            builder.ApplyConfiguration(new PostConfiguration()); //Post
            builder.ApplyConfiguration(new CommentConfiguration()); //Comment
            builder.ApplyConfiguration(new ReplyConfiguration()); //Reply
            builder.ApplyConfiguration(new ReactionConfiguration()); //Reaction
            builder.ApplyConfiguration(new ShareConfiguration()); //Share
        }
    }
}
