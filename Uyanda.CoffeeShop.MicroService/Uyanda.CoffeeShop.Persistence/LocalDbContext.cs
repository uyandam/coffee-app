using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Uyanda.CoffeeShop.Persistence.Entities;


namespace Uyanda.CoffeeShop.Persistence
{
    public class LocalDbContext: DbContext, IUnitOfWork
    {
        private readonly string connectionString = "Data Source = (LocalDB)\\mssqllocaldb;Integrated Security = True; Initial Catalog = CoffeeShop;";

        public LocalDbContext()
        {

        }

        public LocalDbContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(Constants.DataSchema);

            modelBuilder.Entity<BeverageTypeEntity>()
                .HasIndex(c => new { c.Id })
                .IsUnique();

            modelBuilder.Entity<BeverageTypeEntity>()
                .HasData(
                    new BeverageTypeEntity { Id = 1, Name = "Hot"},
                    new BeverageTypeEntity { Id = 2, Name = "Cold"}
                );
            modelBuilder.Entity<BeverageNameEntity>().HasData(
               new BeverageNameEntity { Id = 1,  Name = "Coffee" },
               new BeverageNameEntity { Id = 2,  Name = "Five Roses" },
               new BeverageNameEntity { Id = 3,  Name = "Milkshake" }
               );


            modelBuilder.Entity<BeverageSizeEntity>()
                .HasData(
                    new BeverageSizeEntity { Id = 1, Name = "Small"},
                    new BeverageSizeEntity { Id = 2, Name = "Medium"},
                    new BeverageSizeEntity { Id = 3, Name = "Large"}
                );

            modelBuilder.Entity<BeverageEntity>()
                .HasData(
                    new BeverageEntity { Id = 1, BeverageNameId = 1, BeverageTypeId = 1, BeverageSizeId = 1, PriceId = 1, Count = 1 },
                    new BeverageEntity { Id = 2, BeverageNameId = 2, BeverageTypeId = 1, BeverageSizeId = 1, PriceId = 2, Count = 1 },
                    new BeverageEntity { Id = 3, BeverageNameId = 3, BeverageTypeId = 2, BeverageSizeId = 1, PriceId = 3, Count = 1 },
                    new BeverageEntity { Id = 4, BeverageNameId = 1, BeverageTypeId = 1, BeverageSizeId = 2, PriceId = 4, Count = 1 },
                    new BeverageEntity { Id = 5, BeverageNameId = 2, BeverageTypeId = 1, BeverageSizeId = 2, PriceId = 5, Count = 1 },
                    new BeverageEntity { Id = 6, BeverageNameId = 3, BeverageTypeId = 2, BeverageSizeId = 2, PriceId = 6, Count = 1 },
                    new BeverageEntity { Id = 7, BeverageNameId = 1, BeverageTypeId = 1, BeverageSizeId = 3, PriceId = 7, Count = 1 },
                    new BeverageEntity { Id = 8, BeverageNameId = 2, BeverageTypeId = 1, BeverageSizeId = 3, PriceId = 8, Count = 1 },
                    new BeverageEntity { Id = 9, BeverageNameId = 3, BeverageTypeId = 2, BeverageSizeId = 3, PriceId = 9, Count = 1 }
                );

            modelBuilder.Entity<PriceEntity>()
                .HasData(
                    new PriceEntity { Id = 1, Currency = "ZAR", Price = 15},
                    new PriceEntity { Id = 2, Currency = "ZAR", Price = 25},
                    new PriceEntity { Id = 3, Currency = "ZAR", Price = 30},
                    new PriceEntity { Id = 4, Currency = "ZAR", Price = 10},
                    new PriceEntity { Id = 5, Currency = "ZAR", Price = 15},
                    new PriceEntity { Id = 6, Currency = "ZAR", Price = 20},
                    new PriceEntity { Id = 7, Currency = "ZAR", Price = 20},
                    new PriceEntity { Id = 8, Currency = "ZAR", Price = 30},
                    new PriceEntity { Id = 9, Currency = "ZAR", Price = 40}
                );

        }

        public DbSet<BeverageTypeEntity> BeverageTypes { get; set; }

        public DbSet<BeverageEntity> Beverages { get; set; }

        public DbSet<BeverageNameEntity> BeverageNames { get; set; }

        public DbSet<BeverageSizeEntity> BeverageSizes { get; set; }

        public DbSet<PriceEntity> Prices { get; set; }
    }
}
