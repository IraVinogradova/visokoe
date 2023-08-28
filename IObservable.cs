namespace visokoe
{
    public interface IObservable
    {
        void Add(IObserver observer);
        void Remove(IObserver observer);
        void NotifyObserbers();
    }
}