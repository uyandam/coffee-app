using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }


    }
}
