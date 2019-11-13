using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.ConcreteObservers
{
    public class DecimalObserver : Observer
    {
        public DecimalObserver(Subject subject) : base(subject)
        {
        }

        public override void Update()
        {
            Console.WriteLine($"Decimal string:{ Convert.ToString(Subject.State, 10)}");
        }
    }
}
