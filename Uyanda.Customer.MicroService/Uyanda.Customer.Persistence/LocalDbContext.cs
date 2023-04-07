using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uyanda.Customer.Persistence.Entities;

namespace Uyanda.Customer.Persistence
{
    public class LocalDbContext: DbContext, IUnitOfWork
    {
        private readonly string connectionString = "Data Source = (LocalDB)\\mssqllocaldb;Integrated Security = True; Initial Catalog = Customer;";

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

            modelBuilder.Entity<CustomerEntity>()
                .HasIndex(c => new { c.ContactDetailsId })
                .IsUnique();


            modelBuilder.Entity<ContactDetailsEntity>()
                .HasData(
                    new ContactDetailsEntity { Id = 1, EmailAddress = "dummyemail@example.com", PhoneNumber = "0720000111"}
                );

            modelBuilder.Entity<CustomerEntity>()
                .HasData(new CustomerEntity { Id = 1, ContactDetailsId = 1, Name = "The Rza", Points = 5, Surname = "The Gza" });

        }

        public DbSet<CustomerEntity> Customers { get; set; }

        public DbSet<ContactDetailsEntity> Contacts { get; set; }
    }
}
