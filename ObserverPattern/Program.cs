using System;

namespace ObserverPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("75 in. Led 8K TV", 350);
            IObserver bidder1 = new Bidder("Amir");
            IObserver bidder2 = new Bidder("Ron");
            IObserver bidder3 = new Bidder("Daniel");
            product.Attach(bidder1);
            product.Attach(bidder2);
            product.Attach(bidder3);
            product.SetBidAmount(bidder1, 375);
            product.Detach(bidder2);
            product.SetBidAmount(bidder3, 400);


            /*
            Auctioneer auctioner = new Auctioneer();

            Bidder bidder1 = new Bidder("Amir");
            auctioner.Attach(bidder1);
            Bidder bidder2 = new Bidder("Ron");
            auctioner.Attach(bidder2);
            Bidder bidder3 = new Bidder("Daniel");
            auctioner.Attach(bidder3);

            bidder1.BidNewPrice(10);
            auctioner.NotifyAll();

            bidder2.BidNewPrice(50);
            auctioner.NotifyAll();

            bidder3.BidNewPrice(180);
            auctioner.NotifyAll();

            bidder1.BidNewPrice(255);
            auctioner.NotifyAll();

            bidder2.BidNewPrice(400);
            auctioner.NotifyAll();

            bidder2.BidNewPrice(440);
            auctioner.NotifyAll();

            bidder1.BidNewPrice(480);
            auctioner.NotifyAll();

            */
            Console.ReadKey();
        }
    }
}
