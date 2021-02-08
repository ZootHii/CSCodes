using System;
using CSGameCompanyManagement.Abstracts;
using CSGameCompanyManagement.Entities;

namespace CSGameCompanyManagement.Businesses
{
    public class CheckCustomerManager : ICheckCustomerService
    {
        public bool CheckIfRealCustomer(Customer customer)
        {
            bool result = false;

            result = customer.BirthDate == new DateTime(1999, 8, 1) && customer.NationalityId == "12345678910";

            return result;
        }
    }
}