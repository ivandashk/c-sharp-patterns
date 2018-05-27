namespace Observer
{
    interface ICustomObservable
    {
        void Subscribe(ICustomObserver observers);

        void Unsubscribe(ICustomObserver observer);

        void NotifyObservers();
    }
}
