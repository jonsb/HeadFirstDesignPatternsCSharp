using System;

namespace PatternsOfPatterns
{
    public class DuckSimulator
    {
        public static void Main(string[] args)
        {
            DuckSimulator simulator = new DuckSimulator();
            AbstractDuckFactory duckFactory = new CountingDuckFactory();
            AbstractGooseFactory gooseFactory = new GooseFactory();
            simulator.Simulate(duckFactory, gooseFactory);
        }
        
        void Simulate(AbstractDuckFactory duckFactory, AbstractGooseFactory gooseFactory)
        {
            // Without abstract factory: must remember to use QuackCounter
            // Quackable mallardDuck = new QuackCounter(new MallardDuck());
            // Quackable redheadDuck = new QuackCounter(new RedheadDuck());
            // Quackable duckCall = new QuackCounter(new DuckCall());
            // Quackable rubberDuck = new QuackCounter(new RubberDuck());
            
            // With abstract factory: don't even need to know about QuackCounter 
            Quackable mallardDuck = duckFactory.CreateMallardDuck();
            Quackable redheadDuck = duckFactory.CreateRedheadDuck();
            Quackable duckCall = duckFactory.CreateDuckCall();
            Quackable rubberDuck = duckFactory.CreateRubberDuck();
            Quackable gooseDuck = gooseFactory.CreateGooseDuck();
            
            Console.WriteLine("\nDuck Simulator: With Goose Adapter, Decorator and Abstract Factory");
            
            Simulate(mallardDuck);
            Simulate(redheadDuck);
            Simulate(duckCall);
            Simulate(rubberDuck);
            Simulate(gooseDuck);
            
            Console.WriteLine("The ducks quacked " + QuackCounter.GetQuacks() + " times");
        }
        
        void Simulate(Quackable duck)
        {
            duck.Quack();    
        }
    }
}
