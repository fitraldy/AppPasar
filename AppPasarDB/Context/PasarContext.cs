using AppPasarDB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPasarDB.Context
{
    public class PasarContext : DbContext
    {
        public PasarContext(DbContextOptions<PasarContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Market> Markets { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionDetail> TransactionDetails { get; set; }
    }
}
