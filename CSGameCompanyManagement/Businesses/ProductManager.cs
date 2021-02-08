using System;
using System.Collections.Generic;
using CSGameCompanyManagement.Abstracts;
using CSGameCompanyManagement.Entities;

namespace CSGameCompanyManagement.Businesses
{
    public class ProductManager : IProductService
    {
        public readonly List<Product> products = new List<Product>();
        private readonly ICheckCustomerService _checkCustomerService;

        public ProductManager(ICheckCustomerService checkCustomerService)
        {
            _checkCustomerService = checkCustomerService;
        }

        public void Add(Product product)
        {
            products.Add(product);
        }
        
        public void Sell(Product product, Customer customer)
        {
            if (_checkCustomerService.CheckIfRealCustomer(customer) && products.Contains(product))
            {
                Console.WriteLine(product.Name + " sold to " + customer.FirstName);
            }
            else
            {
                Console.WriteLine("Cannot sell not a valid person.");
            }
        }
    }
}