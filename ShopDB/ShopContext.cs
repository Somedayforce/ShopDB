using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ShopDB
{
    class ShopContext : DbContext
    {
        public ShopContext() : base("Shop") { this.Configuration.AutoDetectChangesEnabled = false; }
    
        public DbSet<Client> clients  {
            get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Sale> sales { get; set; }
        public DbSet<Income> incomes { get; set; }
        public DbSet<Decommission> decommissions { get; set; }
        public DbSet<Provider> providers { get; set; }
        public DbSet<Purchase> purchases { get; set; }
    }
}
