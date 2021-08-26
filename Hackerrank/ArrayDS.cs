using System;
using System.Collections.Generic;
using System.Linq;
using Hackerrank.Interface;

namespace Hackerrank
{
    public class ArrayDS : IRunnable
    {
        public string Run(string[] args)
        {
            var a = Console.ReadLine().Split(' ').Select(x => int.Parse(x));
            var output = ReverseArray(a.ToList());
            return string.Join(" ", output);
        }

        public List<int> ReverseArray(List<int> a)
        {
            var index = 0;
            var len = a.Count - 1;
            
            for(int i = 0; i < a.Count/2; i++, index++)
            {
                var tmp = a[index];
                a[index] = a[len-index];
                a[len-index] = tmp;
            }
            
            return a;
        }
    }
}