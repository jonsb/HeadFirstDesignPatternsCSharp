// Composite pattern: treat a collection of objects in the same way as individual objects
namespace PatternsOfPatterns
{
    public class Flock : Quackable
    {
        IList quackers = new List();
        
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
    }
}