using System;
using System.Collections.Generic;
using Hackerrank.Interface;

namespace Hackerrank
{
    public class StringVowelFinder : IRunnable
    {
        public string Run(string[] args)
        {
            var input = Console.ReadLine().ToUpper();
            var len = input.Length;

            var splitHalf = len / 2;

            var a = input.Substring(0, splitHalf);
            var b = input.Substring(splitHalf - 1, splitHalf);

            var vowels = new List<char> {'A', 'E', 'I', 'O', 'U'};

            var aVowels = 0;

            foreach (var item in vowels)
            {
                if(a.Contains(item))
                {
                    aVowels++;
                }
            }

            var bVowels = 0;

            foreach (var item in vowels)
            {
                if(b.Contains(item))
                {
                    bVowels++;
                }
            }

            return (aVowels == bVowels).ToString();
        }
    }
}