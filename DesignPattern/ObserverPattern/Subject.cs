using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ObserverPattern
{
    public class Subject
    {
        private IList<Observer> observers = new List<Observer>();
        private int state;

        public int State {
            get => state; 
            set {
                state = value;
                NotifyAllObservers();
            } 
        }

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void NotifyAllObservers()
        {           
            foreach (Observer observer in observers)
            {
                observer.Update();
            }
        }
    }
}
