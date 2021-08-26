using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Hackerrank.Interface;

namespace Hackerrank
{
    public class StringReduction : IRunnable
    {
        public string Run(string[] args)
        {
            var n = int.Parse(args[0]);
            int[] outputs = new int[n];
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var output = stringReduction(input).ToString();
                Console.WriteLine($"{i + 1} : {output}");
            }

            return "Executed";
        }

        private int stringReduction(string s)
        {
            for (int i = 0; i < s.Length - 1; i++)
            {
                var const_chars = new List<char> { 'a', 'b', 'c' };
                var c1 = s[i + 1];
                var c2 = s[i];

                if (c1 == c2)
                {
                    continue;
                }

                const_chars.Remove(c1);
                const_chars.Remove(c2);

                var left_element = const_chars.First();
                if (s.Length < 2)
                {
                    continue;
                }
                if (s.Length == 2)
                {
                    s = s.Remove(i, 2);
                    var temp = left_element;
                    s = temp.ToString();
                    continue;
                }
                if (i != s.Length - 2 && left_element == s[i + 2])
                {
                    continue;
                }
                else
                {
                    s = s.Remove(i, 2);
                    var s1 = s.Substring(0, i);
                    var temp = left_element.ToString();
                    if (s.Length != i)
                    {
                        var s2 = s.Substring(i);
                        s = s1 + temp + s2;
                    }
                    else
                    {
                        s = s + temp;
                    }
                    i = -1;
                }
            }

            return s.Length;
        }
    }
}