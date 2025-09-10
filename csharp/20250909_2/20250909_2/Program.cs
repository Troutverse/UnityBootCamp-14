internal class Program
{
    class Solution
    {
        public int solution(int[] numbers, int target)
        {
            int answer = 0;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(numbers[0]);

            while (queue.Count > 0)
            {

            }


            return answer;
        }
    }
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.solution([1, 1, 1, 1, 1], 3));
    }
}