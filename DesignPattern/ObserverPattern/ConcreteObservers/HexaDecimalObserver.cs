using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.ConcreteObservers
{
    public class HexaDecimalObserver : Observer
    {
        public HexaDecimalObserver(Subject subject) : base(subject)
        {
        }

        public override void Update()
        {
            Console.WriteLine($"Hexadecimal string:{ Convert.ToString(Subject.State, 16)}");
        }
    }
}
