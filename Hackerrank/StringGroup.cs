using System.Linq;
using Hackerrank.Interface;

namespace Hackerrank
{
    public class StringGroup : IRunnable
    {
        public string Run(string[] args)
        {
            var str = args[0];

            var output = str.GroupBy(x => x).OrderBy(x => x.Key);

            foreach (var item in output)
            {
                System.Console.WriteLine($"{item.Key} {item.Count()}");
            }

            return string.Empty;
        }
    }
}