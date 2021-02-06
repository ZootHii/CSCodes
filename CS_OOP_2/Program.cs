using CS_OOP_2.Business;
using CS_OOP_2.Entities;

namespace CS_OOP_2
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var customer1 = new NaturalCustomer
            {
                Id = 1,
                CustomerNumber = "12345",
                TcNumber = "12345678910",
                Name = "Ahmet",
                Surname = "Yıldırım"
            };

            var customer2 = new LegalCustomer
            {
                Id = 2,
                CustomerNumber = "54321",
                TaxNumber = "1234567890",
                CompanyName = "ZootHii"
            };

            var customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}