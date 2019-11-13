using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.ConcreteObservers
{
    public class OctalObserver : Observer
    {
        public OctalObserver(Subject subject) : base(subject)
        {
        }

        public override void Update()
        {
            Console.WriteLine($"Octal string:{ Convert.ToString(Subject.State, 8)}");
        }
    }
}
