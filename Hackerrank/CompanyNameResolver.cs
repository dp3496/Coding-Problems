using System;
using System.Linq;
using Hackerrank.Interface;

namespace Hackerrank
{
    public class CompanyNameResolver : IRunnable
    {
        public string Run(string[] args)
        {
            var n = int.Parse(args[0]);
            var m = int.Parse(args[1]);
            var k = int.Parse(args[2]);

            return Resolve(n, m, k).ToString();
        }

        private int Resolve(int n, int m, int k)
        {
            int count = 0;
            string []names = new string[n];

            for(int i = 0; i < n; i++)
            {
                names[i] = Console.ReadLine();
            }

            var gp = names.GroupBy(x => x);
            var possibleOutComes = Math.Pow(k, m) - gp.Count();

            foreach (var g in gp)
            {
                int gCount = g.Count();

                if(gCount > 1)
                {
                    if(possibleOutComes < (gCount - 1))
                    {
                        return -1;
                    }

                    possibleOutComes -= (gCount - 1);
                    count += (gCount - 1);
                }
            }

            return count;
        }
    }
}