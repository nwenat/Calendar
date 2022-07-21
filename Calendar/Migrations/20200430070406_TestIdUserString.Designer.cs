﻿// <auto-generated />
using System;
using Calendar.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Calendar.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200430070406_TestIdUserString")]
    partial class TestIdUserString
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Calendar.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Department");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PhotoPath");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Department = 2,
                            Email = "mary@gmail.com",
                            Name = "Mary"
                        },
                        new
                        {
                            Id = 2,
                            Department = 3,
                            Email = "john@gmail.com",
                            Name = "John"
                        });
                });

            modelBuilder.Entity("Calendar.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("From");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Priority");

                    b.Property<DateTime>("To");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            From = new DateTime(2020, 4, 20, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Praca pon",
                            Priority = 0,
                            To = new DateTime(2020, 4, 20, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "1"
                        },
                        new
                        {
                            Id = 2,
                            From = new DateTime(2020, 4, 20, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Zakupy",
                            Priority = 1,
                            To = new DateTime(2020, 4, 20, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "1"
                        },
                        new
                        {
                            Id = 3,
                            From = new DateTime(2020, 4, 20, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Call",
                            Priority = 0,
                            To = new DateTime(2020, 4, 20, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "1"
                        },
                        new
                        {
                            Id = 4,
                            From = new DateTime(2020, 4, 20, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Kino",
                            Priority = 2,
                            To = new DateTime(2020, 4, 20, 22, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "1"
                        },
                        new
                        {
                            Id = 5,
                            From = new DateTime(2020, 4, 21, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Praca wt",
                            Priority = 0,
                            To = new DateTime(2020, 4, 21, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "1"
                        },
                        new
                        {
                            Id = 6,
                            From = new DateTime(2020, 4, 21, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Zakupy",
                            Priority = 1,
                            To = new DateTime(2020, 4, 21, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "1"
                        },
                        new
                        {
                            Id = 7,
                            From = new DateTime(2020, 4, 21, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Call",
                            Priority = 0,
                            To = new DateTime(2020, 4, 21, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "1"
                        },
                        new
                        {
                            Id = 8,
                            From = new DateTime(2020, 4, 21, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Kino",
                            Priority = 2,
                            To = new DateTime(2020, 4, 21, 22, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "1"
                        },
                        new
                        {
                            Id = 9,
                            From = new DateTime(2020, 4, 22, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Praca sr",
                            Priority = 0,
                            To = new DateTime(2020, 4, 22, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "1"
                        },
                        new
                        {
                            Id = 10,
                            From = new DateTime(2020, 4, 22, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Zakupy",
                            Priority = 1,
                            To = new DateTime(2020, 4, 22, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "1"
                        },
                        new
                        {
                            Id = 11,
                            From = new DateTime(2020, 4, 22, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Call",
                            Priority = 0,
                            To = new DateTime(2020, 4, 22, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "1"
                        },
                        new
                        {
                            Id = 12,
                            From = new DateTime(2020, 4, 22, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Kino",
                            Priority = 2,
                            To = new DateTime(2020, 4, 22, 22, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "1"
                        },
                        new
                        {
                            Id = 13,
                            From = new DateTime(2020, 4, 23, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Praca czw",
                            Priority = 0,
                            To = new DateTime(2020, 4, 23, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "1"
                        },
                        new
                        {
                            Id = 14,
                            From = new DateTime(2020, 4, 23, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Zakupy",
                            Priority = 1,
                            To = new DateTime(2020, 4, 23, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "1"
                        },
                        new
                        {
                            Id = 15,
                            From = new DateTime(2020, 4, 24, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Praca pt",
                            Priority = 0,
                            To = new DateTime(2020, 4, 24, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "1"
                        },
                        new
                        {
                            Id = 16,
                            From = new DateTime(2020, 4, 24, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Zakupy",
                            Priority = 1,
                            To = new DateTime(2020, 4, 24, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "1"
                        },
                        new
                        {
                            Id = 17,
                            From = new DateTime(2020, 4, 25, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Odpoczynek sobota",
                            Priority = 1,
                            To = new DateTime(2020, 4, 25, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "1"
                        },
                        new
                        {
                            Id = 18,
                            From = new DateTime(2020, 4, 26, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Basen niedziela",
                            Priority = 2,
                            To = new DateTime(2020, 4, 26, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "1"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
