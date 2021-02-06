using CSGameCompanyManagement.Entities;

namespace CSGameCompanyManagement.Abstracts
{
    public interface ICheckCustomerService
    {
        bool CheckIfRealCustomer(Customer customer);
    }
}