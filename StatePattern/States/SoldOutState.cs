using System;

namespace StatePattern.States
{
    internal class SoldOutState : IState
    {
        public void InsertQuarter()
        {
            Console.WriteLine("Sorry, machine's sold out''");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You didn't put on a quarter'");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Sorry, sold out");
        }

        public void Dispense()
        {
            Console.WriteLine("No ball dispensed");
        }

        public override string ToString() => "Sold out";
    }
}