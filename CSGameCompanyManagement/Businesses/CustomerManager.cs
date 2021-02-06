using System;
using System.Collections.Generic;
using CSGameCompanyManagement.Abstracts;
using CSGameCompanyManagement.Entities;

namespace CSGameCompanyManagement.Businesses
{
    public class CustomerManager : CheckCustomer, ICustomerService
    {
        public List<Customer> customers = new List<Customer>();

        public void Save(Customer customer)
        {
            if (CheckIfRealCustomer(customer))
            {
                customers.Add(customer);
                Console.WriteLine("Saved: " + customer.FirstName);
            }
            else
            {
                Console.WriteLine("Cannot add not a valid person.");
            }
        }
    }
}