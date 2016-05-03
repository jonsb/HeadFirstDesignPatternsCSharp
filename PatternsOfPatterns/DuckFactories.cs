// Abstract Factory pattern
namespace PatternsOfPatterns
{
    public abstract class AbstractDuckFactory
    {
        public abstract Quackable CreateMallardDuck();
        public abstract Quackable CreateRedheadDuck();
        public abstract Quackable CreateDuckCall();
        public abstract Quackable CreateRubberDuck();
    }

    public class DuckFactory : AbstractDuckFactory
    {
        public override Quackable CreateMallardDuck()
        {
            return new MallardDuck();
        }
        
        public override Quackable CreateRedheadDuck()
        {
            return new RedheadDuck();
        }
        
        public override Quackable CreateDuckCall()
        {
            return new DuckCall();
        }
        
        public override Quackable CreateRubberDuck()
        {
            return new RubberDuck();
        }
    }

    public class CountingDuckFactory : AbstractDuckFactory
    {
        public override Quackable CreateMallardDuck()
        {
            return new QuackCounter(new MallardDuck());
        }
        
        public override Quackable CreateRedheadDuck()
        {
            return new QuackCounter(new RedheadDuck());
        }
        
        public override Quackable CreateDuckCall()
        {
            return new QuackCounter(new DuckCall());
        }
        
        public override Quackable CreateRubberDuck()
        {
            return new QuackCounter(new RubberDuck());
        }
    }    
}