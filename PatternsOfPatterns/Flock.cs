// Composite pattern: treat a collection of objects in the same way as individual objects

using System.Collections.Generic;

namespace DuckSimulator
{
    public class Flock : Quackable
    {        
        IList<Quackable> quackers = new List<Quackable>();
        
        public void Add(Quackable quacker)
        {
            quackers.Add(quacker);
        }
        
        public void Quack()
        {
            foreach (var quacker in quackers)
            {
                quacker.Quack();
            }
        }
        
        public void RegisterObserver(Observer observer)
        {
            foreach (var quacker in quackers)
            {
                quacker.RegisterObserver(observer);
            }
        }
        
        public void NotifyObservers()
        {
            
        }
    }
}