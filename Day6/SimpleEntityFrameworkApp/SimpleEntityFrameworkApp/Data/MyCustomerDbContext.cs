using Microsoft.EntityFrameworkCore;
using SimpleEntityFrameworkApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEntityFrameworkApp.Data
{

    //abastraction for DB itself
    internal class MyCustomerDbContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        //connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = (localdb)\mssqllocaldb;
Initial Catalog = DanAlexkanDb;Integrated Security = True; TrustServerCertificate = True; MultipleActiveResultSets = true");

        }
    }
}
