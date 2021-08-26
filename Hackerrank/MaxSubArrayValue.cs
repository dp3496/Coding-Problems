using System;
using System.Collections.Generic;
using System.Linq;
using Hackerrank.Interface;

namespace Hackerrank
{
    public class MaxSubArrayValue : IRunnable
    {
        public string Run(string[] args)
        {
            var arr = Console.ReadLine().Split(' ');
            var listArr = arr.Select(x => int.Parse(x)).ToList();
            return maxSubarrayValue(listArr).ToString();
        }

        public static long maxSubarrayValue(List<int> arr)
        {
            var count = arr.Count;
            int i = 0;
            while (true)
            {
                for (; i < count; i++)
                {
                    
                }
                
                count--;
                if(count == 0)
                {
                    i++;
                    count = arr.Count;
                }
                else
                {
                    i = 0;
                }

                if(i == count)
                {
                    break;
                }
                    
            }
            return maxValue(arr);
        }

        public static long maxValue(List<int> subArr)
        {
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 0; i < subArr.Count; i++)
            {
                if (i % 2 == 0)
                    evenSum += subArr[i];
                else
                    oddSum += subArr[i];
            }
            var val = evenSum - oddSum;
            return val * val;
        }
    }
}