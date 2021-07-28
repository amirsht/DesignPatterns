using System;

namespace ObserverPattern
{
    public class Bidder : IObserver
    {
        private string bidderName;

        public double bidPrice;
        public override string ToString() => bidderName;

        public Bidder(string name)
        {
            bidderName = name;
        }

        public void BidNewPrice(double price)
        {
            bidPrice = price;
        }

        public void Notify(IObserver observer, String productName, double bidAmount)
        {
            if (observer.ToString().Equals(bidderName))
            {
                Console.WriteLine($"Hello {bidderName}! \nNew bid of amount {bidAmount}$ has been placed on {productName} by you\n");
            }
            else
            {
                Console.WriteLine($"Hello {bidderName}! \nNew bid of amount {bidAmount}$ has been placed on {productName} by {observer.ToString()}\n");
            }
        }
    }
}