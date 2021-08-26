using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using Hackerrank.Interface;

namespace Hackerrank
{
    public class ArrayManipulation : IRunnable
    {
        public string Run(string[] args)
        {
            var n = int.Parse(args[0]);
            var m = int.Parse(args[1]);
            List<List<int>> queries = new List<List<int>>();

            var posMax = queries.Select(x => x[2]).Aggregate((x, y) => x + y);

            var outputs = new long[n + 1];

            for(int i = 0; i < m; i++)
            {
                var q = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
                ProcessQuery(outputs, q);
            }

            return outputs.Max().ToString();
        }

        private void ProcessQuery(long []outputs, IList<int> q)
        {
            for(int i = q[0]; i <= q[1]; i++)
            {
                outputs[i] += q[2];
            }
        }
    }
}