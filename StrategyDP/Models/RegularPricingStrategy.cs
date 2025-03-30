using StrategyDP.Interfaces;

namespace StrategyDP.Models
{
    public class RegularPricingStrategy : PriceStrategy
    {
        public double calculatePrice(double price)
        {
            return price;
        }
    }
}
