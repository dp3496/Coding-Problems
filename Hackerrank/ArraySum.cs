using System;
using Hackerrank.Interface;

namespace Hackerrank
{
    public class ArraySum : IRunnable
    {
        public string Run(string[] args)
        {
            int n = int.Parse(args[0]);
            var input = Console.ReadLine().Split(' ');
            return GetArraySum(input).ToString();
        }

        private static int GetArraySum(string [] input)
        {
            int sum = 0;
            
            for (int i = 0; i < input.Length; i++)
            {
                var value = int.Parse(input[i]);
                sum += value;
            }

            new Sample().TestSample();
            new Sample2().TestSample();

            return sum;
        }
    }

    public class Sample : Sample2
    {
        public Sample()
            : this("")
        {
            
        }

        public Sample(string str)
        {
            
        }
        public Sample(string str, string str1)
        {
            
        }
    }

    public class Sample2
    {

    }

    public static class SampleExtensions
    {
        public static void TestSample<T>(this T sample)
        {
            
        }
    }
}
