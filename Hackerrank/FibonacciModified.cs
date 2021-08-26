using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using Hackerrank.Interface;

namespace Hackerrank
{
    public class FibonacciModified : IRunnable
    {
        public string Run(string[] args)
        {
            var t1 = int.Parse(args[0]);
            var t2 = int.Parse(args[1]);
            var n = int.Parse(args[2]);
            return fibonacciModified(t1, t2, n).ToString();
        }

        BigInteger fibonacciModified(int t1, int t2, int n)
        {
            var fibonacciM = new List<BigInteger>();
            fibonacciM.Add(t1);
            fibonacciM.Add(t2);
            for (int i = 0; i < n - 2; i++)
            {
                fibonacciM.Add(GetNextValue(fibonacciM[i], fibonacciM[i + 1]));
            }

            return fibonacciM.Last();
        }

        BigInteger GetNextValue(BigInteger t1, BigInteger t2)
        {
            return t1 + (t2 * t2);
        }
    }
}