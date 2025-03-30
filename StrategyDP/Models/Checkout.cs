using StrategyDP.Interfaces;

namespace StrategyDP.Models
{
    public class Checkout
    {
        PaymentStrategy paymentStrategy {  get; set; }
        public Checkout(PaymentStrategy _paymentStrategy)
        {
            paymentStrategy = _paymentStrategy;
        }
        public void processPayment(double price)
        {
            paymentStrategy.ProcessPayment(price);
        }
    }
}
