using System;
using CSGameCompanyManagement.Entities;

namespace CSGameCompanyManagement.Abstracts
{
    public abstract class CheckCustomer : ICheckCustomerService
    {
        public bool CheckIfRealCustomer(Customer customer)
        {
            bool result = false;

            result = customer.BirthDate == new DateTime(1999, 8, 1) && customer.NationalityId == "12345678910";

            return result;
        }
    }
}