using Design_Pattern.Interfaces;
using Design_Pattern.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Design_Pattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarketPlaceController : ControllerBase
    {
        [HttpPost]
        public void NotifyUser()
        {
            OnlineMarketPlace onlineMarketPlace = new OnlineMarketPlace();
            ISubscriber subscriber = new Customer("Ahmed");
            ISubscriber subscriber2 = new Customer("carol");
            ISubscriber subscriber3 = new Customer("mina");
            ISubscriber subscriber4 = new Shipping("Amazon");
            onlineMarketPlace.subscribe(EventType.New_Product, subscriber);
            onlineMarketPlace.subscribe(EventType.New_Product, subscriber4);
            onlineMarketPlace.subscribe(EventType.New_Product, subscriber2);
            onlineMarketPlace.subscribe(EventType.New_Offer, subscriber2);
            onlineMarketPlace.subscribe(EventType.Job_Opening, subscriber3);

            onlineMarketPlace.addProduct(new Product { Name = "mobil", Price = 12000 });
            onlineMarketPlace.addOffer(new Offer {Message="50% disscount on shop"});
            onlineMarketPlace.addJobOffer(new JobOffer { Message = "we are hiring backend developers"});
        }
    }
}
