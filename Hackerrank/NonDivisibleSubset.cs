using System;
using System.Collections.Generic;
using System.Linq;
using Hackerrank.Interface;

namespace Hackerrank
{
    public class NonDivisibleSubset : IRunnable
    {
        public string Run(string[] args)
        {
            var n = int.Parse(args[0]);
            var k = int.Parse(args[1]);

            var values = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            return nonDivisibleSubset(k, values).ToString();
        }

        public int nonDivisibleSubset(int k, List<int> s)
        {
            var dict = new Dictionary<int, List<int>>();
            for (int i = 0; i < s.Count; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    continue;
                }

                for (int j = i + 1; j < s.Count; j++)
                {
                    if ((s[i] + s[j]) % k == 0)
                    {
                        continue;
                    }

                    if (dict.TryGetValue(s[i], out List<int> value))
                    {
                        value.Add(s[j]);
                    }
                    else
                    {
                        dict.Add(s[i], new List<int> { s[j] });
                    }
                }
            }

            foreach (var item in dict)
            {
                System.Console.WriteLine($"{item.Key} {string.Join(", ", item.Value)}");
            }

            int maxCount = 0;

            foreach (var item in dict)
            {
                var items = item.Value;
                int count = 1;
                foreach (var val in item.Value)
                {
                    count++;
                    if(dict.TryGetValue(val, out var nfItems))
                    {
                        items = items.Intersect(nfItems).ToList();

                        if(items.Any())
                        {
                            continue;
                        }

                        break;
                    }

                    break;
                }

                if(maxCount < count)
                {
                    maxCount = count;
                }
            }

            //int index = 0;

            // foreach (var keyValue in dict)
            // {
            //     var count = GetPath(index, keyValue.Value, dict);
            //     if(maxCount < count)
            //     {
            //         maxCount = count;
            //     }
            // }

            return maxCount;
        }

        private List<int> GetRemainingItems(int start, List<int> items)
        {
            var remainingItems = new List<int>();

            for(var i = start; i < items.Count; i++)
            {
                remainingItems.Add(items[i]);
            }

            return remainingItems;
        }

        private int GetPath(int start, List<int> items, Dictionary<int, List<int>> dict)
        {
            int count = 2;

            while (items.Any())
            {
                start++;
                var remainingItems = GetRemainingItems(start, items);
                if(!remainingItems.Any())
                {
                    return count;
                }

                items = GetCommanItems(items[start - 1], remainingItems, dict);
                count++;
            }

            return count;
        }

        private List<int> GetCommanItems(int start, List<int> items, Dictionary<int, List<int>> dict)
        {
            if (dict.TryGetValue(start, out List<int> value))
            {
                return value.Intersect(items).ToList();
            }

            return new List<int>();
        }
    }
}