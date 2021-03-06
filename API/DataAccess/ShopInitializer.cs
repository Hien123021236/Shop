using API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace API.DataAccess
{
    public class ShopInitializer: DropCreateDatabaseAlways<Context>
    {
        
        protected override void Seed(Context context)
        {
            context.Productions.AddRange(
                new Production[] {
                    new Production() { ProductionName = "Apple"},
                    new Production() { ProductionName = "Samsung"},
                    new Production() { ProductionName = "LG"},
                    new Production() { ProductionName = "Oppo"},
                }
            );
            GetPhones().ForEach(s => context.Products.Add(s));
            context.SaveChanges();
        }

        private static List<Phone> GetPhones()
        {
            return new List<Phone>
            {
                new Phone
                {
                    Id=1,
                    ProductName = "Apple iPhone 12 Pro Max",
                    BasePrice = 32000000,
                    Price = 28000000,
                    Images = null,
                    Color = "Silver, Graphite, Gold, Pacific Blue",
                    Production = null,
                    Quantity = 10,
                    ReleaseDate = new DateTime(2020, 11, 13)
                    
                },
                new Phone
                {
                    Id=2,
                    ProductName = "Apple iPhone 12 Pro",
                    BasePrice = 29000000,
                    Price = 26000000,
                    Images = null,
                    Color = "Silver, Graphite, Gold, Pacific Blue",
                    Production = null,
                    Quantity = 15,
                    ReleaseDate = new DateTime(2020, 10, 23)
                },
                new Phone
                {
                    Id=3,
                    ProductName = "Samsung Galaxy A21s",
                    BasePrice = 4600000,
                    Price = 4000000,
                    Images = null,
                    Color = "Black, White, Blue, Red",
                    Production = null,
                    Quantity = 5,
                    ReleaseDate = new DateTime(2020, 6, 2)
                },
                new Phone
                {
                    Id=4,
                    ProductName = "Samsung Galaxy M51",
                    BasePrice = 10000000,
                    Price = 9000000,
                    Images = null,
                    Color = "Celestial Black, Electric Blue",
                    Quantity = 3,
                    ReleaseDate = new DateTime(2020, 9, 11)
                },
            };

        }
    }
}