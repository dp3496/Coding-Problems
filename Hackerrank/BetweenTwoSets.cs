using System;
using System.Collections.Generic;
using System.Linq;
using Hackerrank.Interface;

namespace Hackerrank
{
    public class BetweenTwoSets : IRunnable
    {
        public string Run(string[] args)
        {
            var a = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            var b = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();

            var aMax = a.Max();
            var bMin = b.Min();

            var listAFactors = new List<int>();

            for(int i = aMax, index = 1; i <= bMin; i = aMax*index, index++)
            {
                if(a.IsAllFactors(i))
                {
                    listAFactors.Add(i);
                }
            }

            var listBDivisors = new List<int>();

            foreach (var item in listAFactors)
            {
                if(item.IsFactorOfAll(b))
                {
                    listBDivisors.Add(item);
                }
            }
            
            return listBDivisors.Count.ToString();
        }
    }

    public static class FactorExtensions
    {
        public static bool IsAllFactors(this List<int> a, int item)
        {
            foreach (var aItem in a)
            {
                if (item % aItem == 0)
                {
                    continue;
                }

                return false;
            }

            return true;
        }

        public static bool IsFactorOfAll(this int item, List<int> b)
        {
            foreach (var bItem in b)
            {
                if(bItem % item == 0)
                {
                    continue;
                }

                return false;
            }

            return true;
        }
    }
}