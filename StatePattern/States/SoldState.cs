﻿using System;
using StatePattern.Context;

namespace StatePattern.States
{
    internal class SoldState : IState
    {
        private readonly GumballMachine _gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball'");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't give you another gumball");
        }

        public void Dispense()
        {
            _gumballMachine.ReleaseBall();
            if (_gumballMachine.Count > 0)
            {
                _gumballMachine.SetState(_gumballMachine.NoQuarterState);
            }
            else
            {
                _gumballMachine.SetState(_gumballMachine.SoldOutState);
            }
        }

        public override string ToString() => "Sold";
    }
}