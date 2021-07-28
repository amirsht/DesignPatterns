using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public class Product : ISubject
    {
        private List<IObserver> observers;
        private String productName;
        private double bidAmount;
        private IObserver observer;

        public Product(String product, double bid)
        {
            observers = new List<IObserver>();
            productName = product;
            bidAmount = bid;
        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
            Console.WriteLine($"Update: {observer} has withdrawn from bidding" );
        }

        public void NotifyAll()
        {
            foreach (var ob in observers)
            {
                ob.Notify(this.observer, this.productName, this.bidAmount);
            }
        }

        public void SetBidAmount(IObserver observer, double newBidAmount)
        {
            Console.WriteLine("\n*************** New bid placed ***************");
            int res = bidAmount.CompareTo(newBidAmount);
            if (res == -1)
            {
                this.observer = observer;
                this.bidAmount = newBidAmount;
                //setChanged();
                NotifyAll();
            }
            else
            {
                Console.WriteLine("New bid amount cannot be less or equal to current bid amount: " + this.bidAmount);
            }
        }
    }
}
