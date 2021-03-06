// Adapter pattern

namespace DuckSimulator
{
    public class GooseAdapter : Quacker
    {
        Goose goose;
        
        public GooseAdapter(Goose goose)
        {
            this.goose = goose;
        }
        
        public override void Quack()
        {
            goose.Honk();
        }
    }    
}