using System;
using System.Linq;
using Hackerrank.Interface;

namespace Hackerrank
{
    public class UniqueSum : IRunnable
    {
        public string Run(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(x => int.Parse(x));

            var uniques = input.GroupBy(x => x).Where(x => x.Count() == 1);

            int sum = 0;

            foreach (var unique in uniques)
            {
                sum += unique.Key;
            }

            return sum.ToString();
        }
    }
}