using System;
using System.Collections.Generic;
using System.Linq;
using Hackerrank.Interface;

namespace Hackerrank
{
    public class HotelConstruction : IRunnable
    {
        public string Run(string[] args)
        {
            var rows = int.Parse(args[0]);
            var roads = new List<List<int>>();
            for (int i = 0; i < rows; i++)
            {
                roads.Add(Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList());
            }

            return numberOfWays(roads).ToString();
        }

        public static int numberOfWays(List<List<int>> roads)
        {
            var dict = new Dictionary<int, List<int>>();

            foreach (var road in roads)
            {
                if (dict.TryGetValue(road[0], out List<int> value))
                {
                    value.Add(road[1]);
                }
                else
                {
                    dict.Add(road[0], new List<int> { road[1] });
                }
            }

            int output = 0;
            foreach (var dist in dict)
            {
                var val = dist.Value.Count;
                if (val < 3)
                    continue;

                output += Combinations(val, 3);
            }

            return output;
        }

        public static int Combinations(int n, int k)
        {
            int count = n;

            for (int x = 1; x <= k - 1; x++)
            {
                count = count * (n - x) / x;
            }

            return count / k;
        }
    }
}