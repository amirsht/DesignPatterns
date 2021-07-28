using System;

namespace ObserverPattern
{
    public interface IObserver
    {
        void Notify(IObserver observer, String productName, double bidAmount);
    }
}
