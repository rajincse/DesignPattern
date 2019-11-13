using ObserverPattern.ConcreteObservers;
using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            BinaryObserver binaryObserver = new BinaryObserver(subject);
            OctalObserver octalObserver = new OctalObserver(subject);
            DecimalObserver decimalObserver = new DecimalObserver(subject);
            HexaDecimalObserver hexaDecimalObserver = new HexaDecimalObserver(subject);

            int state = 15;
            Console.WriteLine($"First state: {state}");
            subject.State = state;
            state = 10;
            Console.WriteLine($"Second state: {state}");
            subject.State = state; 

        }
    }
}
