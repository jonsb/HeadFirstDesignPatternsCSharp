namespace DuckSimulator
{
    public interface QuackObservable
    {
        void RegisterObserver(Observer observer);
        void NotifyObservers();
    }
}