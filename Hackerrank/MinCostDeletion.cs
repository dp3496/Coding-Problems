using System;
using System.Linq;
using Hackerrank.Interface;

namespace Hackerrank
{
    public class MinCostDeletion : IRunnable
    {
        public string Run(string[] args)
        {
            var input = args[0];
            var cost = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();

            var minCost = 0;

            for(int i = 0; i < (input.Length - 1); i++)
            {
                if(input[i] == input[i + 1])
                {
                    if(cost[i] < cost[i+1])
                    {
                        minCost += cost[i];
                    }
                    else
                    {
                        minCost += cost[i + 1];
                    }
                }
            }

            return minCost.ToString();
        }
    }
}