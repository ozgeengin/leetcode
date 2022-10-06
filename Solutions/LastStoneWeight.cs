// https://leetcode.com/problems/last-stone-weight

namespace Solutions
{
    public class LastStoneWeightProblem
    {
        public int LastStoneWeight(int[] stones)
        {
            var pq = new PriorityQueue<int, int>();
            foreach (var stone in stones)
            {
                pq.Enqueue(-stone,-stone);
            }

            while (pq.Count > 1)
            {
                int stone1 = pq.Dequeue();
                int stone2 = pq.Dequeue();
                var diff = stone1 - stone2;
                if(diff < 0)
                {
                    pq.Enqueue(diff, diff);
                }                   
            }

            return pq.Count == 0 ? 0 : -pq.Peek();
        }
    }
}
