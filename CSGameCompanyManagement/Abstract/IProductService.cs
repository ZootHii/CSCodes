using CSGameCompanyManagement.Entities;

namespace CSGameCompanyManagement.Abstract
{
    public interface IProductService
    {
        void Add(Product product);
        void Sell(Product product, Customer customer);
    }
}