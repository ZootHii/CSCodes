
using CSGameCompanyManagement.Abstract;
using CSGameCompanyManagement.Entities;

namespace CSGameCompanyManagement.Concrete
{
    public class CampaignManager : ICampaignService
    {
        private double temp;
        public void AddDiscount(Campaign campaign, Product product)
        {
            temp = product.Price;
            product.Price = temp - campaign.DiscountPercent * temp;
        }

        public void DeleteDiscount(Campaign campaign, Product product)
        {
            campaign.DiscountPercent = 0;
            product.Price = temp;
        }
        
        public void UpdateDiscount(Campaign campaign, double NewDiscountPercent, Product product)
        {
            campaign.DiscountPercent = NewDiscountPercent;
            product.Price = temp - campaign.DiscountPercent * temp;
        }
    }
}