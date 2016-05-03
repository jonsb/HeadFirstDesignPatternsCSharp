// Decorator pattern

namespace PatternsOfPatterns
{
    public class QuackCounter : Quackable
    {
        Quackable duck;
        static int numberOfQuacks;
        
        public QuackCounter(Quackable duck)
        {
            this.duck = duck;
        }
        
        public void Quack()
        {
            duck.Quack();
            numberOfQuacks++;
        }
        
        public static int GetQuacks()
        {
            return numberOfQuacks;
        }
    }   
}