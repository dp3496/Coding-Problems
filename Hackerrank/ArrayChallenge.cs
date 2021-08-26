using System;
using System.Linq;
using Hackerrank.Interface;

namespace Hackerrank
{
    public class ArrayChallenge : IRunnable
    {
        public string Run(string[] args)
        {
            int n = int.Parse(args[0]);

            int []numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int k = 0;

            int[] result = new int[numbers.Length];

            for(int i = 1; i <= numbers.Length; i++)
            {
                result[i-1] = CalculateToLeft(numbers[k..i], numbers[i-1]);
                System.Console.WriteLine(result[i-1]);
            }

            return string.Empty;
        }

        private int CalculateToLeft(int[] numbers, int num)
        {
            int counter = 0;

            for(int i = (numbers.Length - 2); i >= 0; i--)
            {
                if(num > numbers[i])
                {
                    counter += Math.Abs(num - numbers[i]);
                }
                else
                {
                    counter -= Math.Abs(num - numbers[i]);
                }
            }

            return counter;
        }
    }
}