using System;
using Hackerrank.Interface;

namespace Hackerrank
{
    class CodilityTest2 : IRunnable
    {
        public string Run(string[] args)
        {
            var inputs = new int[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                inputs[i] = int.Parse(args[i]);
            }
            var output1 = solution(inputs, false);
            var output2 = solution(inputs, true);

            if(output1 < output2)
            {
                return output1.ToString();
            }
            else
            {
                return output2.ToString();
            }
        }

         public int solution(int[] A, bool statusChange)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            int heads = 0;
            int tails = 1;

            bool prev_heads = false;
            bool prev_tails = false;

            int count = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == heads)
                {
                    if (prev_tails)
                    {
                        prev_tails = false;
                        prev_heads = true;

                        continue;
                    }

                    if (i == 0)
                    {
                        prev_heads = true;

                        if(!statusChange)
                        {
                            continue;
                        }
                    }

                    count++;
                    prev_tails = true;
                    prev_heads = false;
                }
                if (A[i] == tails)
                {
                    if (prev_heads)
                    {
                        prev_heads = false;
                        prev_tails = true;

                        continue;
                    }

                    if (i == 0)
                    {
                        prev_tails = true;

                        if(!statusChange)
                        {
                            continue;
                        }
                    }

                    count++;
                    prev_heads = true;
                    prev_tails = false;
                }
            }

            return count;
        }
    }
}