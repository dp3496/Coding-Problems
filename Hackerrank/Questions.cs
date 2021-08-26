using System;
using System.Collections.Generic;
using Hackerrank.Interface;

namespace Hackerrank
{
    delegate void Something();

    public class Questions : IRunnable
    {
        public string Run(string[] args)
        {
            var a = new List<Something> { delegate { Console.WriteLine(); } };
            var opt = GetSomething(10); //Option<int>.Some(5);
            opt.Do(x => Console.WriteLine(x));
            return string.Empty;
        }

        public Option<int> GetSomething(int val)
        {
            return None.Value;//Option<int>.None();
        }

        public static Questions operator +(Questions q1, Questions q2)
        {
            return new Questions();
        }

        public static explicit operator bool(Questions item)
        {
            return false;
        }
    }
}