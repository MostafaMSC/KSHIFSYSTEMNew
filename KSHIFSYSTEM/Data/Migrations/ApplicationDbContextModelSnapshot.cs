﻿// <auto-generated />
using System;
using KSHIFSYSTEM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KSHIFSYSTEM.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int?>("AlwasilNo")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime?>("AstmaraDateM")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AstmaraDateP")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int?>("AstmaraNoM")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("AstmaraNoP")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime?>("BookDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("BookNo")
                        .HasColumnType("int");

                    b.Property<string>("BookPic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("HayaBookDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int?>("HayaBookNo")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("JahaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KashefType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("KshefDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MokataNO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Update_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("SpecialBlock")
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

                    b.Property<int?>("AddadAlkhobraa")
                        .HasColumnType("int");

                    b.Property<DateTime?>("AlwasilDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("AlwasilNo")
                        .HasColumnType("int");

                    b.Property<DateTime?>("BookDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("BookNo")
                        .HasColumnType("int");

                    b.Property<DateTime?>("HayaBookDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HayaBookNo")
                        .HasColumnType("int");

                    b.Property<string>("JehaName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("KshefDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("KshifResult")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KshifResultPicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KshifType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MokataNO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName16")
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

                    b.Property<DateTime?>("Update_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
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
                            ConcurrencyStamp = "d13ee49b-ac7b-4dae-ba71-a26bb4fce9e7",
                            Name = "owner",
                            NormalizedName = "OWNER"
                        },
                        new
                        {
                            Id = "admin",
                            ConcurrencyStamp = "534fdb8c-e4d1-435a-8e31-9a54e28368db",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "DawaView",
                            ConcurrencyStamp = "ab6262d1-f3db-48a2-8302-2cd8361bfbb7",
                            Name = "DawaView",
                            NormalizedName = "DAWAVIEW"
                        },
                        new
                        {
                            Id = "eatalaJazaea",
                            ConcurrencyStamp = "c33d63ef-8c20-4bde-b40d-7ee4167f9ee2",
                            Name = "eatalaJazaea",
                            NormalizedName = "EATALAJAZAEA"
                        },
                        new
                        {
                            Id = "admin2",
                            ConcurrencyStamp = "afd993f8-e0d1-4d15-9391-0641850d0a6c",
                            Name = "admin2",
                            NormalizedName = "ADMIN2"
                        },
                        new
                        {
                            Id = "SuperAdmin",
                            ConcurrencyStamp = "99d7f528-2355-4e85-a863-9a20d1eeb068",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = "regulator",
                            ConcurrencyStamp = "4c59fb64-0ba9-49d9-b63f-df59660124f8",
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
                            Id = "admin",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "056ee8bf-d46f-4060-a57a-3a0b44ee41f2",
                            Email = "admin2",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "admin2",
                            NormalizedUserName = "ADMIN2",
                            PasswordHash = "000000",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e26618e5-b010-4e1d-8ce9-45ce9ea31ead",
                            TwoFactorEnabled = false,
                            UserName = "admin2"
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
                            UserId = "admin",
                            RoleId = "admin"
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
