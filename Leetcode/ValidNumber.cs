namespace Leetcode
{
    public class ValidNumber
    {
        public bool IsNumber(string s)
        {
            int length = s.Length;
            bool result = false;
            bool signFound = false;
            bool dotFound = false;
            bool eFound = false;
            bool digitFound = false;
            bool isEFoundLast = false;

            if (length == 0)
            {
                return false;
            }

            for (int i = 0; i < length; i++)
            {
                if (s[i] == '-' || s[i] == '+')
                {
                    if(dotFound && !isEFoundLast)
                        return false;
                    if(digitFound && !eFound)
                        return false;
                    if (signFound && !eFound)
                        return false;
                    if(eFound && !isEFoundLast)
                        return false;

                    signFound = true;
                    result = false;
                    isEFoundLast = false;
                    continue;
                }

                if ((int)s[i] >= 48 && (int)s[i] <= 57)
                {
                    result = true;
                    digitFound = true;
                    isEFoundLast = false;
                    continue;
                }

                if (s[i] == 'e' || s[i] == 'E')
                {
                    if (eFound || !digitFound)
                        return false;

                    eFound = true;
                    isEFoundLast = true;
                    result = false;
                    continue;
                }

                if (s[i] == '.')
                {
                    if (dotFound || eFound)
                        return false;

                    dotFound = true;
                    isEFoundLast = false;
                    continue;
                }

                result = false;
                isEFoundLast = false;
                break;
            }

            return result;
        }
    }
}