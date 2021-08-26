using Hackerrank.Interface;

namespace Hackerrank
{
    public class Palindrome : IRunnable
    {
        public string Run(string[] args)
        {
            var str = args[0];

            for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
            {
                if(str[i] != str[j])
                {
                    return "Not a palindrome";
                }
            }

            return "Palindrome";
        }
    }
}