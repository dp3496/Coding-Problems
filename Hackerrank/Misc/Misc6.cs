using System;

namespace Hackerrank.Misc
{
    public class PrimeVerifier
    {
        public bool Verify(int a)
        {
            int count = 1;

            for(int i = 2; i <= Math.Sqrt(a); i++)
            {
                if(a % i == 0)
                {
                    count++;
                }
            }

            if(count >= 2)
            {
                return false;
            }

            return true;
        }
    }
}