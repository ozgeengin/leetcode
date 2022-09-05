// https://leetcode.com/problems/find-the-distance-value-between-two-arrays/

namespace Solutions
{
    public class FindTheDistanceValueBetweenTwoArrays
    {
        public int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
        {
            int count = 0;
            int arr2Len = arr2.Length;
            for(int i = 0; i < arr1.Length; i++)
            {
                int checks = 0;
                for( int j = 0; j < arr2Len; j++)
                {
                    var diff = Math.Abs(arr1[i] - arr2[j]);
                    if(diff > d)
                    {
                        checks++;
                    }
                }

                if(checks == arr2Len)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
