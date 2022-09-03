// https://leetcode.com/problems/guess-number-higher-or-lower/submissions/

namespace Solutions
{
    public class GuessNumberProblem
    {
        private readonly int Guessed;
        public GuessNumberProblem(int guessed)
        {
            Guessed = guessed;
        }

        public int GuessNumber(int n)
        {
            var left = 1;
            var right = n;

            while (right >= left)
            {
                long sum = right + (long)left;
                int mid = (int)(sum / 2);

                var guessResult = guess(mid);
                if (guessResult == 0)
                {
                    return mid;
                }
                else if (guessResult == 1)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }


        private int guess(int n)
        {
            if (n == Guessed) return 0;
            if(n> Guessed) return -1;

            return 1;
        }
    }
}
