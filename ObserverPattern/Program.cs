using System;

namespace ObserverPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("TV (75 in. Led 8K)", 350);
            IObserver bidder1 = new Bidder("Amir");
            IObserver bidder2 = new Bidder("Ron");
            IObserver bidder3 = new Bidder("Daniel");
            product.Attach(bidder1);
            product.Attach(bidder2);
            product.Attach(bidder3);
            product.SetBidAmount(bidder1, 375);
            product.Detach(bidder2);
            product.SetBidAmount(bidder3, 700);
            Console.ReadKey();
        }
    }
}
