/* AHMET 'ZootHii' YILDIRIM */

using System;
using CSGameCompanyManagement.Concrete;
using CSGameCompanyManagement.Entities;

namespace CSGameCompanyManagement
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var customer1 = new Customer
            {
                Id = 1,
                NationalityId = "12345678910",
                FirstName = "Ahmet",
                LastName = "Yıldırım",
                BirthDate = new DateTime(1999,8,1)
            };
            
            var customer2 = new Customer
            {
                Id = 2,
                NationalityId = "12345678911",
                FirstName = "Ahmet2",
                LastName = "Yıldırım",
                BirthDate = new DateTime(1999,8,1)
            };
            
            var product1 = new Product
            {
                Id = 1,
                Name = "EuroTruck",
                Price = 50
            };
            
            var product2 = new Product
            {
                Id = 2,
                Name = "GTA5",
                Price = 150
            };

            var campaign1 = new Campaign()
            {
                DiscountPercent = 20/100.0,
            };
            
            Console.WriteLine("--------------------------");
            Console.WriteLine("Add Customer");
            var customerManager = new CustomerManager(new CheckCustomerManager());
            customerManager.Save(customer1);
            customerManager.Save(customer2);

            Console.WriteLine("Add Product");
            var productManager = new ProductManager(new CheckCustomerManager());
            productManager.Add(product1);
            productManager.Add(product2);
            
            Console.WriteLine("--------------------------");
            Console.WriteLine("Prices Before Campaign");
            foreach (var product in productManager.products)
            {
                Console.WriteLine("ProductName: " + product.Name + ", ProductPrice: " + product.Price + "$");
            }

            var campaignManager = new CampaignManager();
            campaignManager.AddDiscount(campaign1, product2);

            Console.WriteLine("--------------------------");
            Console.WriteLine("Prices After Campaign");
            Console.WriteLine(campaign1.DiscountPercent  * 100 + "%");
            foreach (var product in productManager.products)
            {
                Console.WriteLine("ProductName: " + product.Name + ", ProductPrice: " + product.Price + "$");
            }
            
            campaignManager.UpdateDiscount(campaign1, 50/100.0, product2);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Prices After Update Campaign");
            Console.WriteLine(campaign1.DiscountPercent  * 100 + "%");
            foreach (var product in productManager.products)
            {
                Console.WriteLine("ProductName: " + product.Name + ", ProductPrice: " + product.Price + "$");
            }
            
            campaignManager.DeleteDiscount(campaign1, product2);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Prices After Delete Campaign");
            Console.WriteLine(campaign1.DiscountPercent  * 100 + "%");
            foreach (var product in productManager.products)
            {
                Console.WriteLine("ProductName: " + product.Name + ", ProductPrice: " + product.Price + "$");
            }
            
            Console.WriteLine("--------------------------");
            Console.WriteLine("Sell Product");
            productManager.Sell(product1, customer2);
            productManager.Sell(product2, customer1);
            Console.WriteLine("--------------------------");
            
        }
    }
}