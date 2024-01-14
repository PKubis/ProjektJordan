﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _4Ballers.Data;

#nullable disable

namespace _4Ballers.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231219043113_InitialSeeds")]
    partial class InitialSeeds
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_4Ballers.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("_4Ballers.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Nike",
                            Description = "Pierwsze z butów zaprojektowane dla Michaela Jordana w 1985 roku",
                            ImageUrl = "jordan1.png",
                            Name = "Jordan I Mid",
                            Price = 599.99m
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Nike",
                            Description = "Michale zagrał w meczu gwiazd, zdobył koronę najlepszego strzelca ligi przekraczając granicę 3000 punktów. Ponadto wygrał konkurs wsadów oraz w dziewięciu kolejnych spotkaniach zdobył 40 i więcej punktów.",
                            ImageUrl = "jordan2.jpg",
                            Name = "Jordan II",
                            Price = 929.99m
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Nike",
                            Description = " Michael ponownie zagrał w meczu gwiazd, trzeci raz z rzędu zdobył tytuł najlepszego strzelca ligi. Jego powietrzne akrobacje oraz słynny jordanowski język stały się jego znakiem firmowym.",
                            ImageUrl = "jordan4.jpg",
                            Name = "Jordan IV",
                            Price = 1863.37m
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Nike",
                            Description = "Z roku na rok Jordan gra coraz lepiej. Ciężka praca popłaca.Michale zdobywa 69 punktów w meczu przeciwko Cavaliers. Zostaje wybrany do pierwszej piątki NBA, występuje w meczy All-Star oraz po raz czwarty z rzędu zdobywa tytuł najlepszego strzelca.",
                            ImageUrl = "jordan5.jpg",
                            Name = "Jordan V",
                            Price = 1049.99m
                        },
                        new
                        {
                            Id = 5,
                            Brand = "Nike",
                            Description = "Trzecie mistrzostwo NBA z zespołem Bulls. Siódmy tytuł najlepszego snajpera ligi. Podczas potyczki finałowej, Jordan zdobywa średnio w meczu 41 punktów.",
                            ImageUrl = "jordan8.jpg",
                            Name = "Jordan VIII",
                            Price = 1364.56m
                        },
                        new
                        {
                            Id = 6,
                            Brand = "Nike",
                            Description = " Pierwszy model obuwia z serii Air Jordan, w których Michael nigdy nie zagrał w meczu ligowym. Jordan odchodzi z NBA i rozpoczyna przygodę z baseball'em.",
                            ImageUrl = "jordan9.png",
                            Name = "Jordan IX",
                            Price = 3947.99m
                        },
                        new
                        {
                            Id = 7,
                            Brand = "Nike",
                            Description = "Tinker Hatfield, który projektował Air Jordan od III do XV, powrócił aby zaprojektować XX. To fani Tinker domagali się aby Nike go o to poprosiło",
                            ImageUrl = "jordan20.jpg",
                            Name = "Jordan XX",
                            Price = 1460.00m
                        },
                        new
                        {
                            Id = 8,
                            Brand = "Nike",
                            Description = "Drugi model wydany dla znakomitego koszykarza Cleavlend Cavaliers LeBron James",
                            ImageUrl = "lebron2.png",
                            Name = "Lebron II",
                            Price = 1399.99m
                        },
                        new
                        {
                            Id = 9,
                            Brand = "Nike",
                            Description = "Jordan Max Aura 4 to sneakersy, które nigdy nie pójdą w odstawkę! Ich wyrazisty design pozwala na tworzenie ciekawych outfitów w klimacie urban-city.",
                            ImageUrl = "MaxAura.png",
                            Name = "Max Aura",
                            Price = 449.00m
                        },
                        new
                        {
                            Id = 10,
                            Brand = "Nike",
                            Description = "Dzięki designowi inspirowanemu wysokim stylem koszykówki i graffiti z lat 90. te buty przyciągają wzrok.",
                            ImageUrl = "pippen.png",
                            Name = "UpTempo",
                            Price = 699.00m
                        },
                        new
                        {
                            Id = 11,
                            Brand = "Nike",
                            Description = "Jedenasta wersja \"Air Jordanów\" została uznana za najbardziej wyjątkową pośród wszystkich modeli obuwia MJ.",
                            ImageUrl = "jordan11.jpg",
                            Name = "Jordan XI",
                            Price = 999.99m
                        },
                        new
                        {
                            Id = 12,
                            Brand = "Nike",
                            Description = "Jordan kontynuuje swą dominację na parkietach ligi NBA, zdobywając czwarty tytuł mistrzowski z Pippenem i spółką z Chicago",
                            ImageUrl = "jordan12.png",
                            Name = "Jordan XII",
                            Price = 999.99m
                        },
                        new
                        {
                            Id = 13,
                            Brand = "Nike",
                            Description = "Trzynastki to jedne z ładniejszych modeli Air Jordans mają gładko przebiegające linie są bardzo żywe. Projekt bazuje na łapie Czarnej Pantery. Zielonkawe holograficzne 'oko' na pięcie przedstawia oko zwierzęcia a podeszwa przypomina łapę. AJ XIII są bardzo wygodne i mają świetną przyczepność",
                            ImageUrl = "jordan13.jpg",
                            Name = "Jordan XIII",
                            Price = 760.99m
                        },
                        new
                        {
                            Id = 14,
                            Brand = "Nike",
                            Description = "Czternasty model \"air jordanów\" nawiązywał do pasji Jordana do samochodów. Styliści zrobili niemalże wszystko, aby ten model był odzwierciedleniem ulubionego auta MJ, Ferrari 550 M",
                            ImageUrl = "jordan14.jpg",
                            Name = "Jordan XIV",
                            Price = 597.00m
                        },
                        new
                        {
                            Id = 15,
                            Brand = "Nike",
                            Description = "Air Jordan specjalnie wykonany na ostatni sezon Michaela Jordana w jego wspaniałej karierze.",
                            ImageUrl = "jordan18.jpg",
                            Name = "Jordan XVIII",
                            Price = 709.00m
                        });
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

            modelBuilder.Entity("_4Ballers.Models.OrderItem", b =>
                {
                    b.HasOne("_4Ballers.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
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
