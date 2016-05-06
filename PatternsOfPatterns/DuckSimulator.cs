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
            Quackable redheadDuck = duckFactory.CreateRedheadDuck();
            Quackable duckCall = duckFactory.CreateDuckCall();
            Quackable rubberDuck = duckFactory.CreateRubberDuck();
            Quackable gooseDuck = gooseFactory.CreateGooseDuck();
            
            Flock flockOfDucks = new Flock();
            flockOfDucks.Add(redheadDuck);
            flockOfDucks.Add(duckCall);
            flockOfDucks.Add(rubberDuck);
            flockOfDucks.Add(gooseDuck);
            
            Quackable mallardOne = duckFactory.CreateMallardDuck();
            Quackable mallardTwo = duckFactory.CreateMallardDuck();
            Quackable mallardThree = duckFactory.CreateMallardDuck();
            Quackable mallardFour = duckFactory.CreateMallardDuck();
            
            Flock flockOfMallards = new Flock();
            flockOfMallards.Add(mallardOne);
            flockOfMallards.Add(mallardTwo);
            flockOfMallards.Add(mallardThree);
            flockOfMallards.Add(mallardFour);
            
            flockOfDucks.Add(flockOfMallards);
            
            Console.WriteLine("\nDuck Simulator: Whole Flock Simulation");
            
            Simulate(flockOfDucks);
            
            Console.WriteLine("\nDuck Simulator: Mallard Flock Simulation");
            
            Simulate(flockOfMallards);
                       
            Console.WriteLine("The ducks quacked " + QuackCounter.GetQuacks() + " times");
        }
        
        void Simulate(Quackable duck)
        {
            duck.Quack();    
        }
    }
}