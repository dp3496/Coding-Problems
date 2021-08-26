using System;
using System.Linq;
using System.Collections.Generic;
using Hackerrank.Interface;

namespace Hackerrank
{
    public class MaximiseBitwise : IRunnable
    {
        public string Run(string[] args)
        {
            int n = int.Parse(args[0]);

            var numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            int k = int.Parse(Console.ReadLine());

            int max = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                for(int j = i; j < numbers.Length; j++)
                {
                    var andRes = CalculateBitwiseAnd(numbers[i..(j + 1)]);

                    if(andRes >= k)
                    {
                        var orResult = CalculateBitwiseOr(numbers[i..(j + 1)]);
                        var sum = numbers[i..(j + 1)].Aggregate((x, y) => x + y);

                        var totalResult = orResult + sum;

                        if(max < totalResult)
                        {
                            max = totalResult;
                        }
                    }
                }
            }

            return max.ToString();
        }

        private int CalculateBitwiseAnd(int[] values)
        {
            int result = values[0];

            for(int i = 1; i < values.Length; i++)
            {
                result = CalculateBitwiseAnd(result, values[i]);
            }

            return result;
        }

        private int CalculateBitwiseOr(int[] values)
        {
            int result = values[0];

            for(int i = 1; i < values.Length; i++)
            {
                result = CalculateBitwiseOr(result, values[i]);
            }

            return result;
        }

        private int CalculateBitwiseAnd(int a, int b)
        {
            var aBinary = GetBinaryValue(a);
            var bBinary = GetBinaryValue(b);

            int resultLength = aBinary.Length > bBinary.Length ? aBinary.Length : bBinary.Length;

            int []result = new int[resultLength];

            for(int i = 0; i < resultLength; i++)
            {
                int aValue = 0;
                int bValue = 0;

                if(i < aBinary.Length)
                {
                    aValue = aBinary[i];
                }

                if(i < bBinary.Length)
                {
                    bValue = bBinary[i];
                }

                if(aValue == 1 && bValue == 1)   
                {
                    result[i] = 1;
                }
                else
                {
                    result[i] = 0;
                }
            }

            return GetDecimalValue(result);
        }

        private int CalculateBitwiseOr(int a, int b)
        {
            var aBinary = GetBinaryValue(a);
            var bBinary = GetBinaryValue(b);

            int resultLength = aBinary.Length > bBinary.Length ? aBinary.Length : bBinary.Length;

            int []result = new int[resultLength];

            for(int i = 0; i < resultLength; i++)
            {
                int aValue = 0;
                int bValue = 0;

                if(i < aBinary.Length)
                {
                    aValue = aBinary[i];
                }

                if(i < bBinary.Length)
                {
                    bValue = bBinary[i];
                }

                if(aValue == 1 || bValue == 1)   
                {
                    result[i] = 1;
                }
                else
                {
                    result[i] = 0;
                }
            }

            return GetDecimalValue(result);
        }

        private int[] GetBinaryValue(int number)
        {
            var values = new List<int>();

            while(true)
            {
                var remainder = number % 2;
                number = number / 2;

                values.Add(remainder);

                if(number <= 1)
                {
                    values.Add(number);
                    break;
                }
            }

            return values.ToArray();
        }

        private int GetDecimalValue(int[] binaryValues)
        {
            int sum = 0;
            int index = 0;

            foreach (var binaryValue in binaryValues)
            {
                sum += binaryValue * (int)Math.Pow(2, index);
                index++;
            }

            return sum;
        }
    }
}