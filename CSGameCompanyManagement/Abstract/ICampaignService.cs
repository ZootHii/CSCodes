using CSGameCompanyManagement.Entities;

namespace CSGameCompanyManagement.Abstract
{
    public interface ICampaignService
    {
        void AddDiscount(Campaign campaign, Product product);
        void DeleteDiscount(Campaign campaign, Product product);
        void UpdateDiscount(Campaign campaign, double NewDiscountPercent, Product product);
    }
}