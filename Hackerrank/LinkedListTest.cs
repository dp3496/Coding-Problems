using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using Hackerrank.Interface;

namespace Hackerrank
{
    public class LinkedListTest : IRunnable
    {
        public string Run(string[] args)
        {
            var lList = new LinkedList<int>();

            lList.Add(10);
            lList.Add(20);
            lList.Add(30);
            lList.Add(40);

            System.Console.WriteLine(lList[3]);
            Print(lList);

            return TryRemoveItems(lList, 60).ToString();
        }

        public bool TryRemoveItems<T>(ILinkedList<T> list, T item)
        {
            var result = list.Remove(item);

            foreach (var lItem in list)
            {
                Console.WriteLine($"{lItem}");
            }

            return result;
        }

        [Benchmark]
        private void Print(IEnumerable<int> list)
        {
            //var temp = list.Where(x => x >= 30);
            
            foreach(var item in list)
            {
                System.Console.WriteLine($"{item}");
            }
        }
    }
}