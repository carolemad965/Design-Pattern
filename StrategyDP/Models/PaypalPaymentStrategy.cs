using StrategyDP.Interfaces;

namespace StrategyDP.Models
{
    public class PaypalPaymentStrategy : PaymentStrategy
    {
        public void ProcessPayment(double price)
        {
            Console.WriteLine($"using Paypal For Payment:{price}");
        }
    }
}
