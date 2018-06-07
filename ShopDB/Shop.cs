namespace ShopDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Shop : DbContext
    {
        public Shop()
            : base("name=Shop")
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Decommission> Decommissions { get; set; }
        public virtual DbSet<Income> Incomes { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }
        public virtual DbSet<Purchase> Purchases { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<Client>()
                .Property(e => e.adress)
                .IsFixedLength();

            modelBuilder.Entity<Income>()
                .Property(e => e.price)
                .HasPrecision(19, 4);

           

            modelBuilder.Entity<Product>()
                .Property(e => e.type)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.measure)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.buyprice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.sellprice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Provider>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<Provider>()
                .Property(e => e.product_name)
                .IsFixedLength();

            modelBuilder.Entity<Provider>()
                .Property(e => e.adress)
                .IsFixedLength();

            modelBuilder.Entity<Provider>()
        ;
            
            modelBuilder.Entity<Sale>()
                .Property(e => e.price)
                .HasPrecision(19, 4);
        }
    }
}
