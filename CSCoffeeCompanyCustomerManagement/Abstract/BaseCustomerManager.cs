using System;
using CSCoffeeCompanyCustomerManagement.Entities;

namespace CSCoffeeCompanyCustomerManagement.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Save to Database: " + customer.FirstName);   
        }
    }
}