using System;
using CSCoffeeCompanyCustomerManagement.Abstract;
using CSCoffeeCompanyCustomerManagement.Concrete;
using CSCoffeeCompanyCustomerManagement.Entities;

namespace CSCoffeeCompanyCustomerManagement
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer{Id = 1, FirstName = "Ahmet", LastName = "Yıldırım",
                NationalityId = "34063582562", DateOfBirth = new DateTime(1999,01,08)});
        }
    }
}