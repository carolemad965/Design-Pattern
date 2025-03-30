using StrategyDP.Interfaces;

namespace StrategyDP.Models
{
    public class Product
    {
        public string? Name { get; set; }
        public double Price { get; set; }
        public PriceStrategy PriceStrategy { get; set; }
        public Product(string name,double price,PriceStrategy priceStrategy)
        {
            PriceStrategy = priceStrategy;
            Name = name;
            Price = price;
        }
        public double CalculatePrice()
        {
           return PriceStrategy.calculatePrice(Price);
        }
    }
}
