using Hackerrank.Interface;
using System;
using System.Collections.Generic;

namespace Hackerrank
{
    public class MatrixSpecialPosCounter : IRunnable
    {
        public string Run(string[] args)
        {
            var n = int.Parse(args[0]);
            var onesYPositions = new List<int>();
            var specialPosCounter = 0;

            for(int i = 0; i < n; i++)
            {
                var (foundOnce, onesPosition) = TryGetUniqueYPositions(Console.ReadLine());
                if(foundOnce)
                {
                    if(onesYPositions.Contains(onesPosition))
                    {
                        specialPosCounter--;
                    }
                    else
                    {
                        onesYPositions.Add(onesPosition);
                        specialPosCounter++;   
                    }                    
                }
            }

            return specialPosCounter.ToString();
        }

        private (bool, int) TryGetUniqueYPositions(string str)
        {
            int onesPos = 0;
            bool multipleOneExists = false;
            var cols = str.Split(' ');

            for(int i = 0; i < cols.Length; i++)
            {
                if(cols[i] == "1")
                {
                    if(multipleOneExists)
                    {
                        return (false, 0);
                    }

                    onesPos = i;
                    multipleOneExists = true;
                }
            }

            return (true, onesPos);
        }
    }
}