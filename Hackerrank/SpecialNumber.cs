using System.Linq;
using Hackerrank.Interface;

namespace Hackerrank
{
    public class SpecialNumber : IRunnable
    {
        public string Run(string[] args)
        {
            var number = int.Parse(args[0]);

            var numberSum = GetNumberSum(number);

            for(int i = (number + 1);;i++)
            {
                if(GetNumberSum(i) == (numberSum * 2))
                {
                    return i.ToString();
                }
            }
        }

        private int GetNumberSum(int number)
        {
            var sum = 0;

            while(number > 9)
            {
                sum += number % 10;
                number = number / 10;
            }

            sum += number;

            return sum;
        }
    }
}