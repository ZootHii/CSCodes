using CSGameCompanyManagement.Entities;

namespace CSGameCompanyManagement.Abstract
{
    public interface ICheckCustomerService
    {
        bool CheckIfRealCustomer(Customer customer);
    }
}