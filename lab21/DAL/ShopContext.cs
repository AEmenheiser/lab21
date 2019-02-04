using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using lab21.Models;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace lab21.DAL
{
    public class ShopContext : DbContext

    {
        public ShopContext() : base("ShopContext")
        {
            Database.SetInitializer(new ShopInitializer());
        }

        public DbSet<RegisterClass> Customer { get; set; }
        public DbSet<ItemClass> Item { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}