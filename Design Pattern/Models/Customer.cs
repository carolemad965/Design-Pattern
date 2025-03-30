using Design_Pattern.Interfaces;

namespace Design_Pattern.Models
{
    public class Customer:ISubscriber
    {
        public string Name { get; set; }      
        public Customer (string name)
        {
            Name = name;
        }
        public void notify(string message)
        {
            Console.WriteLine($"{Name} is notified with this message:{message}");
        }
       
    }
}
