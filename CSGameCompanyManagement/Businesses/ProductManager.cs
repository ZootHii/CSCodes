using System;
using System.Collections.Generic;
using CSGameCompanyManagement.Abstracts;
using CSGameCompanyManagement.Entities;

namespace CSGameCompanyManagement.Businesses
{
    public class ProductManager : CheckCustomer, IProductService
    {
        public List<Product> products = new List<Product>();

        public void Add(Product product)
        {
            products.Add(product);
        }
        
        public void Sell(Product product, Customer customer)
        {
            if (CheckIfRealCustomer(customer) && products.Contains(product))
            {
                Console.WriteLine(product.Name + " sold to " + customer.FirstName);
            }
            else
            {
                Console.WriteLine("Cannot sell not a valid person or product.");
            }
        }
    }
}