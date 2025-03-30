using StrategyDP.Interfaces;

namespace StrategyDP.Models
{
    public class BankTransferPaymentStrategy : PaymentStrategy
    {
        public void ProcessPayment(double price)
        {
            Console.WriteLine($"using Bank Transfer For Payment:{price}");
        }
    }
}
