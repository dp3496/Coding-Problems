namespace Hackerrank
{
    public class HexaDecimal
    {
        private static readonly string []hexValues = new string[] {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F"};
        public string ConvertToHex(int number)
        {
            string output = string.Empty;

            while(number > 16)
            {
                var remainder = number % 16;
                number = number / 16;
                output += hexValues[remainder];
            }

            output += number.ToString();

            return output;
        }

        public int ConvertToDecimal(string hex)
        {
            for(int i = 0; i < hexValues.Length; i++)
            {
                if(hex == hexValues[i])
                {
                    return i;
                }
            }

            return 0;
        }
    }
}