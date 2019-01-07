using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportStoreEF.Data {
    public static class SportsStoreDataInitializer {
        public static void InitializeData(ApplicationDbContext dbContext) {
            Product football = new Product("Football", 25, "WK colors");
            Product cornerflags = new Product("Corner flags", 34.95M, "Give your playing field that professional touch");
            Product shoes = new Product("Running shoes", 95, "Protective and fashionable");
            Product surfboard = new Product("Surf board", 275, "A boat for one person");
            Product kayak = new Product("Kayak", 170, "High quality");
            Product lifeJacket = new Product("Lifejacket", 49.99M, "Protective and fashionable");
            Product[] products = { football, cornerflags, shoes, surfboard, kayak, lifeJacket };

            dbContext.products.AddRange(products);

            City gent = new City { Name = "Gent", Postalcode = "9000" };
            City antwerpen = new City { Name = "Antwerpen", Postalcode = "3000" };
            City[] cities = { gent, antwerpen };

            dbContext.Cities.AddRange(cities);

            Random r = new Random();

            for (int i = 1; i < 10; i++) {
                Customer klant = new Customer("student" + i, "Student" + i, "Jan", "Nieuwstraat 10", cities[r.Next(2)]);
                if (i <= 5) {
                    Cart cart = new Cart();
                    cart.AddLine(football, 1);
                    cart.AddLine(cornerflags, 2);
                    klant.PlaceOrder(cart, DateTime.Today, false, klant.Street, klant.City);
                }
                dbContext.Customers.Add(klant);
            }
            dbContext.SaveChanges();
        }
    }
}
