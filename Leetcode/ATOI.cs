using System;

namespace Leetcode
{
    public class ATOI
    {
        public int MyAtoi(string s)
        {
            string result = string.Empty;

            bool digitFound = false;

            s = s.TrimStart();

            if(s.Length > 0 && (s[0] == '-' || s[0] == '+'))
            {
                result += s[0];
                s = s[1..];
            }

            for (int i = 0; i < s.Length; i++)
            {
                if((int)s[i] >= 48 && (int)s[i] <= 57)
                {
                    result += s[i];
                    digitFound = true;
                    continue;
                }

                if((!digitFound || (s[i] == '-' || s[i] == '+')))
                    result = "0";

                break;
            }

            if(!int.TryParse(result, out var number))
            {
                if(s == string.Empty || result.Length <= 1)
                    return 0;
                if(result[0] == '-')
                    return int.MinValue;
                return int.MaxValue;
            }

            return number;
        }
    }
}