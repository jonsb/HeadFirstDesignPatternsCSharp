using System;
using System.Text;
using StatePattern.States;

namespace StatePattern.Context
{
    public class GumballMachine
    {
        internal IState SoldOutState { get; }
        internal IState NoQuarterState { get; }
        internal IState HasQuarterState { get; }
        internal IState SoldState { get; }
        internal IState WinnerState { get; set; }

        internal IState State { get; private set; }
        internal int Count { get; private set; } = 0;

        public GumballMachine(int gumballCount)
        {
            SoldOutState = new SoldOutState();
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);
            WinnerState = new WinnerState(this);
            
            Count = gumballCount;
            State = gumballCount > 0 ? NoQuarterState : SoldOutState;
        }

        public void InsertQuarter()
        {
            State.InsertQuarter();
        }

        public void EjectQuarter()
        {
            State.EjectQuarter();
        }

        public void TurnCrank()
        {
            State.TurnCrank();
            State.Dispense();
        }

        internal void SetState(IState state)
        {
            State = state;
        }

        internal void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out of the slot...");

            if (Count > 0)
            {
                Count--;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("State: " + State);
            sb.AppendLine("Count: " + Count);
            return sb.ToString();
        }
    }
}