using CSCoffeeCompanyCustomerManagement.Entities;

namespace CSCoffeeCompanyCustomerManagement.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}