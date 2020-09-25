// Abstract Factory pattern
namespace DuckSimulator
{
    public abstract class AbstractGooseFactory
    {
        public abstract Goose CreateGoose();
        public abstract Quackable CreateGooseDuck();        
    }

    public class GooseFactory : AbstractGooseFactory
    {
        public override Goose CreateGoose()
        {
            return new Goose();
        }
        
        public override Quackable CreateGooseDuck()
        {
            return new GooseAdapter(new Goose());
        }        
    }    
}