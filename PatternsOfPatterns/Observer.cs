using System;

public interface Observer
{
    void Update(QuackObservable duck);
}

public class Quackologist : Observer
{
    public void Update(QuackObservable duck)
    {
        Console.WriteLine("Quackologist: " + duck + " just quacked.");
    }
}