using System;
using System.Collections.Generic;
using CSGameCompanyManagement.Abstracts;
using CSGameCompanyManagement.Entities;

namespace CSGameCompanyManagement.Businesses
{
    public class CustomerManager : ICustomerService
    {
        public readonly List<Customer> customers = new List<Customer>();
        private readonly ICheckCustomerService _checkCustomerService;

        public CustomerManager(ICheckCustomerService checkCustomerService)
        {
            _checkCustomerService = checkCustomerService;
        }


        public void Save(Customer customer)
        {
            if (_checkCustomerService.CheckIfRealCustomer(customer))
            {
                customers.Add(customer);
                Console.WriteLine("Saved: " + customer.FirstName);
                Console.WriteLine("Total Customers: " + customers.Count);
            }
            else
            {
                Console.WriteLine("Cannot add not a valid person.");
            }
        }
    }
}