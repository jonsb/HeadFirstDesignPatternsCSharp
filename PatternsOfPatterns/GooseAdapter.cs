// Adapter pattern

namespace PatternsOfPatterns
{
    public class GooseAdapter : Quackable
    {
        Goose goose;
        
        public GooseAdapter(Goose goose)
        {
            this.goose = goose;
        }
        
        public void Quack()
        {
            goose.Honk();
        }
    }    
}