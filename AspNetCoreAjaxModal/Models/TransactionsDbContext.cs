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

        }

        public DbSet<TransactionModel> Transactions { get; set; }

        public DbSet<BankModel> Banks { get; set; }
    }
}
