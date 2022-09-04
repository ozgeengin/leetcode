// https://leetcode.com/problems/peak-index-in-a-mountain-array/

namespace Solutions
{
    public class PeakIndexInAMountainArray
    {
        public int PeakIndexInMountainArray(int[] arr)
        {
            (int index, int value) peak = (int.MinValue, int.MinValue);
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (peak.value < arr[i])
                {
                    peak.value = arr[i];
                    peak.index = i;
                }
                else
                {
                    return peak.index;
                }
            }

            return -1;
        }

        public int PeakIndexInMountainArrayAlternative(int[] arr)
        {
            int left = 0, right = arr.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] < arr[mid + 1])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }

            return left;
        }
    }
}
