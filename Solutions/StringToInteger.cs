// https://leetcode.com/problems/string-to-integer-atoi/

using System.Text;

namespace Solutions
{
    public class StringToInteger
    {
        public int MyAtoi(string s)
        {
            s = s.TrimStart();
            if (s == string.Empty)
            {
                return 0;
            }

            var sb = new StringBuilder();
            s = s.TrimStart();
            var sign = GetSign(s[0]);

            
            if(sign == Sign.Negative)
            {
                sb.Append('-');
            }

            var index = sign == Sign.None ? 0 : 1;

            for (int i = index; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    sb.Append(s[i]);
                }
                else
                {
                    break;
                }
            }

            return Clamp(sb.ToString(), sign == Sign.Negative);
        }

        private Sign GetSign(char c)
        {
            if (c == '-') return Sign.Negative;
            if (c == '+') return Sign.Positive;

            return Sign.None;
        }

        private int Clamp(string value, bool isNegative)
        {
            if (value == string.Empty || (value.Length == 1 && !char.IsDigit(value[0])))
            {
                return 0;
            }

            if (!int.TryParse(value, out int result))
            {
                return isNegative ? int.MinValue : int.MaxValue;
            }

            return result;
        }
    }

    public enum Sign
    {
        None,
        Negative,
        Positive
    }
}
