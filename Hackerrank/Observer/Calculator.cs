using System;
using System.Collections.Generic;
using System.Linq;

namespace Hackerrank.Observer
{
    public class Calculator
    {
        private List<ICalculatorObserver> _observers;

        public Calculator()
        {
            _observers = new List<ICalculatorObserver>();
        }

        public void AddObserver(ICalculatorObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(ICalculatorObserver observer)
        {
            _observers.Remove(observer);
        }

        public int Add(int a, int b)
        {
            var sum = a + b;
            NotifyObservers(sum, typeof(AddSubObserver));
            return sum;
        }

        public int Mul(int a, int b)
        {
            var mul = a * b;
            NotifyObservers(mul, typeof(MulDivObserver));
            return mul;
        }

        private void NotifyObservers(int result, Type type)
        {
            var observers = _observers.Where(x => x.GetType() == type);

            foreach (var observer in observers)
            {
                observer.Notify(result)   ;
            }
        }
    }
}