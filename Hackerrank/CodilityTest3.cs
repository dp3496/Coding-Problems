using System;
using Hackerrank.Interface;

namespace Hackerrank
{
    public class CodilityTest3 : IRunnable
    {
        public string Run(string[] args)
        {
            int N = int.Parse(args[0]);
            int K = int.Parse(args[1]);

            return Solution(N, K).ToString();
        }

        public int Solution(int N, int K)
        {
            if(N==K)
            {
                return 1;
            }
            int sum=K;
            int count=0;
            for (int i=N; i>0; i--)
            {
                if (sum-i < 0)
                {
                    continue;
                }
                
                sum=sum-i;
                count++;

                if(sum == 0)
                {
                    break;
                }
            }
            if(sum != 0)
            {
                return -1;
            }
            
            return count;
        }
    }
}