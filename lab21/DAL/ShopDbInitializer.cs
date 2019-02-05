using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lab21.Models;
using System.Data.Entity;

namespace lab21.DAL
{
    public class ShopInitializer : System.Data.Entity.CreateDatabaseIfNotExists<ShopContext>
    {

        protected override void Seed(ShopContext context)
        {
            var customer = new List<RegisterClass>
            {
                new RegisterClass{FirstName="Adam", LastName = "Emenheiser", Email="Fakeemail.com", PhoneNumber=123432123,},
                new RegisterClass{FirstName="ben", LastName = "hur", Email="fun.com", PhoneNumber=123432123,}

            };

           
            customer.ForEach(s => context.Customer.Add(s));
            context.SaveChanges();

            var items = new List<ItemClass>
            {
                new ItemClass{Price=1, Description="coffee", Name="small coffee", Quantity=1,}
            };

            items.ForEach(x => context.Item.Add(x));
            context.SaveChanges();
        }
    }
}