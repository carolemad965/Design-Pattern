using StrategyDP.Interfaces;

namespace StrategyDP.Models
{
    public class VisaCardPaymentStrategy : PaymentStrategy
    {
        public void ProcessPayment(double price)
        {
            Console.WriteLine($"using Visa Card For Payment:{price}");
        }
    }
}
