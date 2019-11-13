using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public abstract class Observer
    {
        protected Subject Subject { get; set; }
        public Observer(Subject subject)
        {
            Subject = subject;
            subject.Attach(this);
        }
        public abstract void Update();
    }
}
