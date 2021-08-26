using System;
using System.Linq;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            bool enable = true;
            while(enable)
            {
                var input = Console.ReadLine();
                switch (input)
                {
                    case "q":
                        enable = false;
                        System.Console.WriteLine("Exited!");
                        break;
                    default:
                        RunValidNumber(input);
                        break;
                }
            }
        }

        static void RunMediaTwoArrays()
        {
            var firstArr = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var secondArr = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            Console.WriteLine(new MediaTwoArrays().FindMedianSortedArrays(
                firstArr,
                secondArr).ToString());
        }

        static void RunATOI()
        {
            var input = Console.ReadLine();
            Console.WriteLine(new ATOI().MyAtoi(input));
        }

        static void RunValidNumber(string input)
        {
            Console.WriteLine(new ValidNumber().IsNumber(input));
        }
    }
}
