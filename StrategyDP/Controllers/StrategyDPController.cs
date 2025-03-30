using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StrategyDP.Models;

namespace StrategyDP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StrategyDPController : ControllerBase
    {
        [HttpGet]
        public void Test()
        {
            Product wallet = new("wallet", 100, new RegularPricingStrategy());
            double FinalPrice=wallet.CalculatePrice();
            Console.WriteLine(FinalPrice.ToString());

            Product jacket = new("jacket", 1000, new GoldPricingStrategy());
            double FinalPrice2 = jacket.CalculatePrice();
            Console.WriteLine(FinalPrice2.ToString());

            Product phone = new("phone", 10000, new PremiumPricingStrategy());
            double FinalPrice3 = phone.CalculatePrice();
            Console.WriteLine(FinalPrice3.ToString());

            Checkout Walletcheckout = new(new PaypalPaymentStrategy());
            Checkout Phonecheckout = new(new VisaCardPaymentStrategy());

            Walletcheckout.processPayment(FinalPrice);
            Phonecheckout.processPayment(FinalPrice2);
        }
    }
}
