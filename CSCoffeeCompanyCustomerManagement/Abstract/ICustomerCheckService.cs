using CSCoffeeCompanyCustomerManagement.Entities;

namespace CSCoffeeCompanyCustomerManagement.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealCustomer(Customer customer);
    }
}