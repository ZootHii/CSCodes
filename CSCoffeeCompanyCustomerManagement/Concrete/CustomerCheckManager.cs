using CSCoffeeCompanyCustomerManagement.Abstract;
using CSCoffeeCompanyCustomerManagement.Entities;

namespace CSCoffeeCompanyCustomerManagement.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealCustomer(Customer customer)
        {
            return true;
        }
    }
}