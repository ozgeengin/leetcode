// https://leetcode.com/problems/kth-largest-element-in-a-stream

namespace Solutions
{
    public class KthLargest
    {
        private readonly PriorityQueue<int, int> pq;
        private readonly int k;

        public KthLargest(int k, int[] nums)
        {
            this.k = k;
            pq = new PriorityQueue<int, int>();
            foreach (var num in nums)
            {
                CheckSizeAndAdd(num);
            }
        }

        public int Add(int val)
        {
            CheckSizeAndAdd(val);

            return pq.Peek();
        }

        private void CheckSizeAndAdd(int val)
        {
            pq.Enqueue(val, val);
            if (pq.Count > k)
                pq.Dequeue();
        }
    }
}
