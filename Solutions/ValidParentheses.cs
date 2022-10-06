// https://leetcode.com/problems/valid-parentheses

namespace Solutions
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '}')
                {
                    if (IsInvalid(stack, '{'))
                    {
                        return false;
                    }
                }
                else if (s[i] == ')')
                {
                    if (IsInvalid(stack, '('))
                    {
                        return false;
                    }
                }
                else if (s[i] == ']')
                {
                    if (IsInvalid(stack, '['))
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(s[i]);
                }
            }

            return stack.Count == 0;
        }

        private bool IsInvalid(Stack<char> stack, char c)
        {
            return stack.Count == 0 || stack.Pop() != c;
        }
    }
}
