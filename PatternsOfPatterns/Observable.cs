using System.Collections.Generic;

namespace DuckSimulator
{
    public class Observable : QuackObservable
    {
        IList<Observer> observers = new List<Observer>();
        QuackObservable duck;
    
        public Observable(QuackObservable duck)
        {
            this.duck = duck;
        }
    
        public void RegisterObserver(Observer observer)
        {
            observers.Add(observer);
        }
    
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(duck);
            }
        }
    }
}