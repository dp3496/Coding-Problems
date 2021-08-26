using System;
using Hackerrank.Interface;
using Hackerrank.Sorting;

namespace Hackerrank
{
    public class MergeSortTest : IRunnable
    {
        public string Run(string[] args)
        {
            var items = new int[5] { 5, 2, 3, 4, 1 };
            MergeSort.Sort(items);

            foreach(var item in items)
            {
                Console.Write(item);
            }
            
            return string.Empty;
        }
    }
}