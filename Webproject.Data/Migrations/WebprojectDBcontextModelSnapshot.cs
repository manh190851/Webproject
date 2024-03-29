﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Webproject.Data.EF;

#nullable disable

namespace Webproject.Data.Migrations
{
    [DbContext(typeof(WebprojectDbContext))]
    partial class WebprojectDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RoleId", "UserId");

                    b.ToTable("AppUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserToken", (string)null);
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.AccountImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<long>("AccId")
                        .HasColumnType("bigint");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccId");

                    b.ToTable("AccountImage", (string)null);
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppRoles", (string)null);
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("https://icon-library.com/images/icon-user/icon-user-15.jpg");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Nation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppUsers", (string)null);
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.Category", b =>
                {
                    b.Property<int>("CateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CateId"), 1L, 1);

                    b.Property<string>("CateName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CateId");

                    b.ToTable("Categories", (string)null);
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.Comment", b =>
                {
                    b.Property<long>("ComId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ComId"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<long>("PostId")
                        .HasColumnType("bigint");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ComId");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments", (string)null);
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.Follow", b =>
                {
                    b.Property<long>("FollowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("FollowId"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("FollowerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FollowingId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FollowId");

                    b.HasIndex("FollowerId");

                    b.HasIndex("FollowingId");

                    b.ToTable("Follows", (string)null);
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.Friend", b =>
                {
                    b.Property<long>("FriendId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("FriendId"), 1L, 1);

                    b.Property<Guid>("AcceptId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("RequestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.HasKey("FriendId");

                    b.HasIndex("AcceptId");

                    b.HasIndex("RequestId");

                    b.ToTable("Friends", (string)null);
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GameId"), 1L, 1);

                    b.Property<int>("CateId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GameName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameId");

                    b.HasIndex("CateId");

                    b.ToTable("Games", (string)null);
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.GameAccount", b =>
                {
                    b.Property<long>("AccId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("AccId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SalerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("_Account")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccId");

                    b.HasIndex("GameId");

                    b.HasIndex("SalerId");

                    b.ToTable("GameAccount", (string)null);
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.Message", b =>
                {
                    b.Property<long>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("MessageId"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ReceiverId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SenderId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MessageId");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages", (string)null);
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.Post", b =>
                {
                    b.Property<long>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("PostId"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<long>("ShareCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValue(0L);

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts", (string)null);
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.Reaction", b =>
                {
                    b.Property<long>("ReacId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ReacId"), 1L, 1);

                    b.Property<long>("ComId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<long>("PostId")
                        .HasColumnType("bigint");

                    b.Property<int>("ReacName")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<long>("ReplyId")
                        .HasColumnType("bigint");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ReacId");

                    b.HasIndex("ComId");

                    b.HasIndex("PostId");

                    b.HasIndex("ReplyId");

                    b.HasIndex("UserId");

                    b.ToTable("Reactions", (string)null);
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.Reply", b =>
                {
                    b.Property<long>("ReplyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ReplyId"), 1L, 1);

                    b.Property<long>("ComId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReplyContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ReplyId");

                    b.HasIndex("ComId");

                    b.HasIndex("UserId");

                    b.ToTable("Replys", (string)null);
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.Share", b =>
                {
                    b.Property<long>("ShareId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ShareId"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<long>("PostId")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ShareId");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Shares", (string)null);
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.AccountImage", b =>
                {
                    b.HasOne("Webproject.Data.EntityModel.GameAccount", "Account")
                        .WithMany("Images")
                        .HasForeignKey("AccId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.Comment", b =>
                {
                    b.HasOne("Webproject.Data.EntityModel.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Webproject.Data.EntityModel.AppUser", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.Follow", b =>
                {
                    b.HasOne("Webproject.Data.EntityModel.AppUser", "Follower")
                        .WithMany("Following")
                        .HasForeignKey("FollowerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Webproject.Data.EntityModel.AppUser", "Following")
                        .WithMany("Followers")
                        .HasForeignKey("FollowingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Follower");

                    b.Navigation("Following");
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.Friend", b =>
                {
                    b.HasOne("Webproject.Data.EntityModel.AppUser", "AcceptUser")
                        .WithMany("AcceptFriends")
                        .HasForeignKey("AcceptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Webproject.Data.EntityModel.AppUser", "RequestUser")
                        .WithMany("RequestFriends")
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AcceptUser");

                    b.Navigation("RequestUser");
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.Game", b =>
                {
                    b.HasOne("Webproject.Data.EntityModel.Category", "Category")
                        .WithMany("Games")
                        .HasForeignKey("CateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.GameAccount", b =>
                {
                    b.HasOne("Webproject.Data.EntityModel.Game", "Game")
                        .WithMany("Accounts")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Webproject.Data.EntityModel.AppUser", "Saler")
                        .WithMany()
                        .HasForeignKey("SalerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Saler");
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.Message", b =>
                {
                    b.HasOne("Webproject.Data.EntityModel.AppUser", "Receiver")
                        .WithMany("ReceiveMessage")
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Webproject.Data.EntityModel.AppUser", "Sender")
                        .WithMany("SendMessage")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Receiver");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.Post", b =>
                {
                    b.HasOne("Webproject.Data.EntityModel.AppUser", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.Reaction", b =>
                {
                    b.HasOne("Webproject.Data.EntityModel.Comment", "Comment")
                        .WithMany("Reactions")
                        .HasForeignKey("ComId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Webproject.Data.EntityModel.Post", "Post")
                        .WithMany("Reactions")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Webproject.Data.EntityModel.Reply", "Reply")
                        .WithMany("Reactions")
                        .HasForeignKey("ReplyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Webproject.Data.EntityModel.AppUser", "User")
                        .WithMany("Reactions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comment");

                    b.Navigation("Post");

                    b.Navigation("Reply");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.Reply", b =>
                {
                    b.HasOne("Webproject.Data.EntityModel.Comment", "Comment")
                        .WithMany("Replys")
                        .HasForeignKey("ComId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Webproject.Data.EntityModel.AppUser", "User")
                        .WithMany("Replys")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.Share", b =>
                {
                    b.HasOne("Webproject.Data.EntityModel.Post", "Post")
                        .WithMany("Shares")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Webproject.Data.EntityModel.AppUser", "Users")
                        .WithMany("Shares")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.AppUser", b =>
                {
                    b.Navigation("AcceptFriends");

                    b.Navigation("Comments");

                    b.Navigation("Followers");

                    b.Navigation("Following");

                    b.Navigation("Posts");

                    b.Navigation("Reactions");

                    b.Navigation("ReceiveMessage");

                    b.Navigation("Replys");

                    b.Navigation("RequestFriends");

                    b.Navigation("SendMessage");

                    b.Navigation("Shares");
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.Category", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.Comment", b =>
                {
                    b.Navigation("Reactions");

                    b.Navigation("Replys");
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.Game", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.GameAccount", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.Post", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Reactions");

                    b.Navigation("Shares");
                });

            modelBuilder.Entity("Webproject.Data.EntityModel.Reply", b =>
                {
                    b.Navigation("Reactions");
                });
#pragma warning restore 612, 618
        }
    }
}
