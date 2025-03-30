using StrategyDP.Interfaces;

namespace StrategyDP.Models
{
    public class Product
    {
        public string? Name { get; set; }
        public double Price { get; set; }
        public double CalculatePrice(PriceStrategy priceStrategy)
        {
           return priceStrategy.calculatePrice(Price);
        }
    }
}
