using StrategyDP.Interfaces;

namespace StrategyDP.Models
{
    public class PremiumPricingStrategy : PriceStrategy
    {
        public double calculatePrice(double price)
        {
            return price * 0.8;
        }
    }
}
