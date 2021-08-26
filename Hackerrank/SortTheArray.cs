using System;
using System.Linq;
using Hackerrank.Interface;

namespace Hackerrank
{
    public class SortTheArray : IRunnable
    {
        public string Run(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(x => int.Parse(x));

            var OrderSummaries = input.GroupBy(x => x)
                                      .Select(x => (x.Key, Count: x.Count()))
                                      .OrderByDescending(x => x.Count)
                                      .ThenBy(x => x.Key);

            foreach(var summary in OrderSummaries)
            {
                Console.WriteLine($"{summary.Key} {summary.Count}");
            }

            return string.Empty;
        }
    }
}