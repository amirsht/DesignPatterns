namespace ObserverPattern
{
    interface ISubject
    {
        void Attach(IObserver observer);

        void Detach(IObserver observer);

        void NotifyAll();

        public void SetBidAmount(IObserver observer, double newBidAmount);
    }
}
