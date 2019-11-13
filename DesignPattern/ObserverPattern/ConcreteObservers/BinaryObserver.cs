using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.ConcreteObservers
{
    public class BinaryObserver : Observer
    {
        public BinaryObserver(Subject subject) : base(subject)
        {
        }

        public override void Update()
        {
            Console.WriteLine($"Binary string:{ Convert.ToString(Subject.State, 2)}");
        }
    }
}
