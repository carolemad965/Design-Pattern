using Design_Pattern.Interfaces;

namespace Design_Pattern.Models
{
    public class Shipping : ISubscriber
    {
        private string companyName {  get; set; }
        public Shipping(string CompanyName) 
        {
            companyName = CompanyName;
        }
        public void notify(string message)
        {
            Console.WriteLine($"{companyName} is notified by :{message}");
        }
    }
}
