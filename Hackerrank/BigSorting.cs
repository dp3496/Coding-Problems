using System;
using System.Linq;
using System.Numerics;
using Hackerrank.Interface;

namespace Hackerrank
{
    public class BigSorting : IRunnable
    {
        public string Run(string[] args)
        {
            throw new System.NotImplementedException();
        }

        private string[] Sorting(string[] unsorted)
        {
            BigInteger[] items = new BigInteger[unsorted.Length];
        
            for(int i = 0; i < unsorted.Length; i++)
            {
                items[i] = BigInteger.Parse(unsorted[i]);
            }
        
            Array.Sort(unsorted.Cast<BigInteger>().ToArray());

            string[] sorted = new string[unsorted.Length];

            for (int i = 0; i < unsorted.Length; i++)
            {
                sorted[i] = items[i].ToString();
            }

            return sorted;
        }
    }
}