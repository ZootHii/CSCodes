using System;

namespace CS_OOP_1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var product1 = new Product
            {
                Id = 1,
                CategoryId = 2,
                ProductName = "Masa",
                UnitPrice = 500,
                UnitsInStock = 3,
            };

            var product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                ProductName = "Kalemm",
                UnitPrice = 35,
                UnitsInStock = 5,
            };
            
            var product3 = new Product
            {
                Id = 3,
                CategoryId = 5,
                ProductName = "SİL",
                UnitPrice = 35,
                UnitsInStock = 5,
            };
            
            var product4 = new Product
            {
                Id = 4,
                CategoryId = 7,
                ProductName = "Bilgisayar",
                UnitPrice = 3500,
                UnitsInStock = 50,
            };

            var productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Add(product2);
            productManager.Add(product3);
            productManager.Add(product4);
            
            Console.WriteLine("----- AFTER ADD -----");
            foreach (var product in productManager.products)
            {
                Console.WriteLine("Index Of Products: " + productManager.products.IndexOf(product));
                Console.WriteLine("ID: " + product.Id + " CategoryID: " + product.CategoryId + " ProductName: " + product.ProductName 
                                  + " UnitPrice: " + product.UnitPrice + " UnitsInStock: " + product.UnitsInStock);
            }
            Console.WriteLine("Size of Products: " + productManager.products.Count);
            
            var product2Update = new Product
            {
                Id = 2,
                CategoryId = 5,
                ProductName = "Kalem",
                UnitPrice = 35,
                UnitsInStock = 5,
            };
            productManager.Update(product2,product2Update);
            Console.WriteLine("----- AFTER UPDATE -----");
            foreach (var product in productManager.products)
            {
                Console.WriteLine("Index Of Products: " + productManager.products.IndexOf(product));
                Console.WriteLine("ID: " + product.Id + " CategoryID: " + product.CategoryId + " ProductName: " + product.ProductName 
                                  + " UnitPrice: " + product.UnitPrice + " UnitsInStock: " + product.UnitsInStock);
            }
            Console.WriteLine("Size of Products: " + productManager.products.Count);
            productManager.Delete(product3);
            Console.WriteLine("----- AFTER DELETE -----");
            foreach (var product in productManager.products)
            {
                Console.WriteLine("Index Of Products: " + productManager.products.IndexOf(product));
                Console.WriteLine("ID: " + product.Id + " CategoryID: " + product.CategoryId + " ProductName: " + product.ProductName 
                                  + " UnitPrice: " + product.UnitPrice + " UnitsInStock: " + product.UnitsInStock);
            }
            
            Console.WriteLine("Size of Products: " + productManager.products.Count);
        }
    }
}