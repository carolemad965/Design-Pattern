using StrategyDP.Interfaces;

namespace StrategyDP.Models
{
    public class GoldPricingStrategy : PriceStrategy
    {
        public double calculatePrice(double price)
        {
           return price * 0.9;
        }
    }
}
