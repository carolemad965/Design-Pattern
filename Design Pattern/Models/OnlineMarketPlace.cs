using Design_Pattern.Interfaces;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Design_Pattern.Models
{
    public class OnlineMarketPlace
    {
        private List<Customer> Users { get; set; } = new();
        private Dictionary<EventType, List<ISubscriber>> Subscribers { get; set; } = new();
        private List<Product> Products { get; set; } = new();
        private List<Offer> Offers { get; set; } = new();
        private List<JobOffer> jobOffers { get; set; } = new();
        public OnlineMarketPlace() 
        {
            initSubscribers();
        }

        private void initSubscribers()
        {
            Subscribers[EventType.New_Product] = new List<ISubscriber>();
            Subscribers[EventType.New_Offer] = new List<ISubscriber>();
            Subscribers[EventType.Job_Opening] = new List<ISubscriber>();
        }

        public void subscribe(EventType eventType,ISubscriber subscriber)
        {
            Subscribers[eventType].Add(subscriber);
        }
        public void unSubscribe(EventType eventType, ISubscriber subscriber)
        {
            Subscribers[eventType].Remove(subscriber);
        }
        public void addProduct(Product product)
        {
            Products.Add(product);
            notifySubscribers(EventType.New_Product, $"New Product Added:{product.Name}");
        }
        public void addOffer(Offer offer)
        {
            Offers.Add(offer);
            notifySubscribers(EventType.New_Offer, $"New Offer Added:{offer.Message}");

        }
        public void addJobOffer(JobOffer jobOffer)
        {
            jobOffers.Add(jobOffer);
            notifySubscribers(EventType.Job_Opening, $"New Job Offer Added:{jobOffer.Message}");

        }
        private void notifySubscribers(EventType eventType, string message)
        {
            Subscribers[eventType].ForEach(s=>s.notify(message));
        }

       
        
        
    }
}
