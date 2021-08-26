using System;
using System.Collections.Generic;
using System.Linq;
using Hackerrank.Interface;

namespace Hackerrank
{
    class CodilityTest1 : IRunnable
    {
        public string Run(string[] args)
        {
            return solution(args[0]).ToString();
        }

        public int solution(string S) {
            int count = 0;
            var items = new int[S.Length];

            int initialSumCheck = 0;

            for (int i = 0; i < S.Length; i++)
            {
                items[i] = int.Parse(S[i].ToString());
                initialSumCheck += items[i];
            }

            if(initialSumCheck % 3 == 0)
            {
                count++;
            }

            for(int i = 0; i < items.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < items.Length; j++)
                {
                    if(i == j)
                    {
                        continue;
                    }
                    sum += items[j];
                }
                for(int j = 0; j < 10; j++)
                {
                    if(j == items[i]) continue;

                    if((sum + j) % 3 == 0)
                    {
                        count++;
                        j = j + 2;
                    }
                }
            }

            return count;
        }

        private bool GetSum(string S)
        {
            int sum = 0;
            for(int i = 0; i < S.Length; i++)
            {
                sum += int.Parse(S[i].ToString());
            }

            if(sum % 3 == 0)
            {
                return true;
            }

            return false;
        }
    }
}