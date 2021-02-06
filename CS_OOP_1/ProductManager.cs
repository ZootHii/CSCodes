using System;
using System.Collections.Generic;

namespace CS_OOP_1
{
    public class ProductManager // Operations related to Product (Entities)
    {
        public List<Product> products;

        public ProductManager()
        {
            products = new List<Product>();
        }
        
        public void Add(Product product)
        {
            //TODO make it a proper method
            products.Add(product);
            Console.WriteLine(product.ProductName + " Added.");
        }

        public void Update(Product product, Product toUpdate)
        {
            //TODO make it a proper method
            products.Insert(products.IndexOf(product), toUpdate);
            products.Remove(product);
            Console.WriteLine(product.ProductName + " Updated to " + toUpdate.ProductName);
        }

        public void Delete(Product product)
        {
            products.Remove(product);
            Console.WriteLine(product.ProductName + " Deleted.");
        }
    }
}