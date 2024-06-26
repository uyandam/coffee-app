﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Uyanda.CoffeeShop.Persistence;

#nullable disable

namespace Uyanda.CoffeeShop.Persistence.Migrations
{
    [DbContext(typeof(LocalDbContext))]
    [Migration("20221127172430_UpdateBeverageEntityToStartCountWithValueOne")]
    partial class UpdateBeverageEntityToStartCountWithValueOne
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("CoffeeShop")
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Uyanda.CoffeeShop.Persistence.Entities.BeverageEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BeverageNameId")
                        .HasColumnType("int");

                    b.Property<int>("BeverageSizeId")
                        .HasColumnType("int");

                    b.Property<int>("BeverageTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("BeverageNameId");

                    b.HasIndex("BeverageSizeId");

                    b.HasIndex("BeverageTypeId");

                    b.ToTable("Beverages", "CoffeeShop");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BeverageNameId = 1,
                            BeverageSizeId = 1,
                            BeverageTypeId = 1,
                            Count = 1,
                            Price = 15m
                        },
                        new
                        {
                            Id = 2,
                            BeverageNameId = 2,
                            BeverageSizeId = 1,
                            BeverageTypeId = 1,
                            Count = 1,
                            Price = 25m
                        },
                        new
                        {
                            Id = 3,
                            BeverageNameId = 3,
                            BeverageSizeId = 1,
                            BeverageTypeId = 2,
                            Count = 1,
                            Price = 30m
                        },
                        new
                        {
                            Id = 4,
                            BeverageNameId = 1,
                            BeverageSizeId = 2,
                            BeverageTypeId = 1,
                            Count = 1,
                            Price = 10m
                        },
                        new
                        {
                            Id = 5,
                            BeverageNameId = 2,
                            BeverageSizeId = 2,
                            BeverageTypeId = 1,
                            Count = 1,
                            Price = 15m
                        },
                        new
                        {
                            Id = 6,
                            BeverageNameId = 3,
                            BeverageSizeId = 2,
                            BeverageTypeId = 2,
                            Count = 1,
                            Price = 20m
                        },
                        new
                        {
                            Id = 7,
                            BeverageNameId = 1,
                            BeverageSizeId = 3,
                            BeverageTypeId = 1,
                            Count = 1,
                            Price = 20m
                        },
                        new
                        {
                            Id = 8,
                            BeverageNameId = 2,
                            BeverageSizeId = 3,
                            BeverageTypeId = 1,
                            Count = 1,
                            Price = 30m
                        },
                        new
                        {
                            Id = 9,
                            BeverageNameId = 3,
                            BeverageSizeId = 3,
                            BeverageTypeId = 2,
                            Count = 1,
                            Price = 40m
                        });
                });

            modelBuilder.Entity("Uyanda.CoffeeShop.Persistence.Entities.BeverageNameEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BeverageNames", "CoffeeShop");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Coffee"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Five Roses"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Milkshake"
                        });
                });

            modelBuilder.Entity("Uyanda.CoffeeShop.Persistence.Entities.BeverageSizeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BeverageSizes", "CoffeeShop");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Small"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Medium"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Large"
                        });
                });

            modelBuilder.Entity("Uyanda.CoffeeShop.Persistence.Entities.BeverageTypeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("BeverageTypes", "CoffeeShop");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Hot"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Cold"
                        });
                });

            modelBuilder.Entity("Uyanda.CoffeeShop.Persistence.Entities.BeverageEntity", b =>
                {
                    b.HasOne("Uyanda.CoffeeShop.Persistence.Entities.BeverageNameEntity", "BeverageName")
                        .WithMany()
                        .HasForeignKey("BeverageNameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Uyanda.CoffeeShop.Persistence.Entities.BeverageSizeEntity", "BeverageSize")
                        .WithMany()
                        .HasForeignKey("BeverageSizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Uyanda.CoffeeShop.Persistence.Entities.BeverageTypeEntity", "BeverageType")
                        .WithMany()
                        .HasForeignKey("BeverageTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BeverageName");

                    b.Navigation("BeverageSize");

                    b.Navigation("BeverageType");
                });
#pragma warning restore 612, 618
        }
    }
}
