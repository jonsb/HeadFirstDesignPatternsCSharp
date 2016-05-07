namespace PatternsOfPatterns
{
    public interface Quackable : QuackObservable 
    {
        void Quack();    
    }
    
    // Alternative to interface, to encapsulate common behavior for all quackables
    public abstract class Quacker : Quackable
    {
        Observable observable;
        
        public abstract void Quack();
        
        protected Quacker()
        {
            observable = new Observable(this);
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

    public class MallardDuck : Quacker
    {        
        public MallardDuck() : base() { }
        
        public override void Quack()
        {
            System.Console.WriteLine("Quack");
            NotifyObservers();
        }
    }

    public class RedheadDuck : Quacker
    {
        public RedheadDuck() : base() { }
        
        public override void Quack()
        {
            System.Console.WriteLine("Quack");
            NotifyObservers();
        }
    }
    
    public class DuckCall : Quacker
    {
        public DuckCall() : base() { }
        
        public override void Quack()
        {
            System.Console.WriteLine("Kwak");
            NotifyObservers();
        }
    }

    public class RubberDuck : Quacker
    {
        public RubberDuck() : base() { }
        
        public override void Quack()
        {
            System.Console.WriteLine("Squeak");
            NotifyObservers();
        }
    }    
}