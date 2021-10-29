using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreAjaxModal.Models
{
    public class TransactionsDbContext : DbContext
    {
        public TransactionsDbContext(DbContextOptions<TransactionsDbContext> options):base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<TransactionModel> Transactions { get; set; }

        public DbSet<BankModel> Banks { get; set; }

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySql(
                "server=localhost;user=root;password=12345678;database=usersdb5;",
                new MySqlServerVersion(new Version(8, 0, 27))
            );
        }
        */
    }
}
