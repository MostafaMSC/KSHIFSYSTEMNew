﻿// <auto-generated />
using System;
using KSHIFSYSTEM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KSHIFSYSTEM.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231105144011_10special")]
    partial class _10special
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("KSHIFSYSTEM.Models.BookInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AddadAlkhobraa")
                        .HasColumnType("int");

                    b.Property<DateTime?>("AlwasilDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("AlwasilNo")
                        .HasColumnType("int");

                    b.Property<DateTime?>("AstmaraDateM")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AstmaraDateP")
                        .HasColumnType("datetime2");

                    b.Property<int?>("AstmaraNoM")
                        .HasColumnType("int");

                    b.Property<int?>("AstmaraNoP")
                        .HasColumnType("int");

                    b.Property<DateTime?>("BookDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("BookNo")
                        .HasColumnType("int");

                    b.Property<string>("BookPic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("HayaBookDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HayaBookNo")
                        .HasColumnType("int");

                    b.Property<string>("JahaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KashefType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("KshefDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PlaceNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("BookTable");
                });

            modelBuilder.Entity("KSHIFSYSTEM.Models.DaawaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AkherALajraaat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AstanafNO")
                        .HasColumnType("int");

                    b.Property<string>("Court")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DawaNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DawaSubject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DawaType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Decision1ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Decision1Num")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Office")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SelectDawa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TameezNO")
                        .HasColumnType("int");

                    b.Property<int>("TashehNO")
                        .HasColumnType("int");

                    b.Property<int>("qraraadaNO")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DawwaTable");
                });

            modelBuilder.Entity("KSHIFSYSTEM.Models.KhobraaMahakemModule", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KshofatNo")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("khobraaMahakemTable");
                });

            modelBuilder.Entity("KSHIFSYSTEM.Models.KshfInfoModule", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KshifType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KshofatNo")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalKSofat")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("SpecialestTable");
                });

            modelBuilder.Entity("KSHIFSYSTEM.Models.TarshehBook", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("BookNo")
                        .HasColumnType("int");

                    b.Property<string>("JehaName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("KshefDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("KshifResult")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KshifType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlaceNo")
                        .HasColumnType("int");

                    b.Property<string>("SpecaialName1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("WasilDateM")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("WasilDateP")
                        .HasColumnType("datetime2");

                    b.Property<int?>("WasilNoM")
                        .HasColumnType("int");

                    b.Property<int?>("WasilNoP")
                        .HasColumnType("int");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TarshehBookTable");
                });

            modelBuilder.Entity("KSHIFSYSTEM.Models.TotalKsofatModule", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KshodatNOAqaraat")
                        .HasColumnType("int");

                    b.Property<int>("KshofatNoMahakem")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalKshofat")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("TotalKshofatTable");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "owner",
                            ConcurrencyStamp = "6c6a7270-b604-4c2c-9ec7-d99b31e2794b",
                            Name = "owner",
                            NormalizedName = "OWNER"
                        },
                        new
                        {
                            Id = "admin",
                            ConcurrencyStamp = "ce881f4c-8eba-4a98-88de-0e07e99e4daa",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "DawaView",
                            ConcurrencyStamp = "9fbc4e01-23e6-4966-9363-f19ba5e62be4",
                            Name = "DawaView",
                            NormalizedName = "DAWAVIEW"
                        },
                        new
                        {
                            Id = "eatalaJazaea",
                            ConcurrencyStamp = "9a559214-1901-47bd-a3df-6130d18810db",
                            Name = "eatalaJazaea",
                            NormalizedName = "EATALAJAZAEA"
                        },
                        new
                        {
                            Id = "admin2",
                            ConcurrencyStamp = "3ba1fa00-34af-4f85-94f7-3509bc8bed3d",
                            Name = "admin2",
                            NormalizedName = "ADMIN2"
                        },
                        new
                        {
                            Id = "SuperAdmin",
                            ConcurrencyStamp = "d1486945-2cbc-4ad9-8dee-42c1cf4b40d5",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = "regulator",
                            ConcurrencyStamp = "c67a31e5-765d-4fa0-8f24-100ad31b75a6",
                            Name = "regulator",
                            NormalizedName = "REGULATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ab475087-4ca8-48c7-9f52-d6ee0afc7695",
                            Email = "admin",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "admin",
                            NormalizedUserName = "admin",
                            PasswordHash = "000000",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8ddc11b0-ae4d-4b6b-b893-0cfa833c8206",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "cvfgrtbvdscvfd",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "081e79c4-0968-4d69-978a-1c8023a0337d",
                            Email = "admin",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "admin",
                            NormalizedUserName = "ADMIN2",
                            PasswordHash = "000000",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7ac86df3-1ee6-441a-b18b-702a070f70ed",
                            TwoFactorEnabled = false,
                            UserName = "admin2"
                        },
                        new
                        {
                            Id = "dASDadadasdasdasdsa",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d194d566-e77e-488c-aee8-7a8056be61fc",
                            Email = "owner",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "owner",
                            NormalizedUserName = "OWNER",
                            PasswordHash = "000000",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "cfb71a87-1721-42a5-a4af-dbb1692b848d",
                            TwoFactorEnabled = false,
                            UserName = "owner"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                            RoleId = "oi2eoij-1oqjsdkj-kaslk-OwnerRole"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
