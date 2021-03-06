using API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace API.DataAccess
{
    public class Context : DbContext
    {
        public Context() : base("name=Shop-connectionString")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Bill>().ToTable("Bill");
            modelBuilder.Entity<BillItem>().ToTable("BillItem");
            modelBuilder.Entity<Promotion>().ToTable("Promotion");
            modelBuilder.Entity<Payment>().ToTable("Payment");
            modelBuilder.Entity<Status>().ToTable("Status");
            modelBuilder.Entity<InventoryReceiving>().ToTable("InventoryReceiving");
            modelBuilder.Entity<InventoryReceivingItem>().ToTable("InventoryReceivingItem");
            modelBuilder.Entity<Account>().ToTable("Account");
            modelBuilder.Entity<RoleLevel>().ToTable("RoleLevel");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Production>().ToTable("Production");
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillItem> BillItems { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<ConsigneeInformation> ConsigneesInformation { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<InventoryReceiving> InventoryReceivings { get; set; }
        public DbSet<InventoryReceivingItem> InventoryReceivingItems { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<RoleLevel> RoleLevels { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Production> Productions { get; set; }
    }
}
