namespace PatternsOfPatterns
{
    public interface Quackable 
    {
        void Quack();    
    }    

    public class MallardDuck : Quackable, QuackObservable
    {
        Observable observable;
        
        public MallardDuck()
        {
            observable = new Observable(this);
        }
        
        public void Quack()
        {
            System.Console.WriteLine("Quack");
            NotifyObservers();
        }
        
        public void RegisterObserver(Observer observer)
        {
            observable.RegisterObserver(observer);
        }
        
        public void NotifyObservers()
        {
            observable.NotifyObservers();
        }
    }

    public class RedheadDuck : Quackable
    {
        public void Quack()
        {
            System.Console.WriteLine("Quack");
        }
    }

    public class DuckCall : Quackable
    {
        public void Quack()
        {
            System.Console.WriteLine("Kwak");
        }
    }

    public class RubberDuck : Quackable
    {
        public void Quack()
        {
            System.Console.WriteLine("Squeak");
        }
    }    
}