namespace _20250729
{
    public class Study
    {
        static void Main(string[] args)
        {
            string s = "1 2 3 4";
            int[] answer = s.Split(' ').Select(int.Parse).ToArray();

            // 결과를 확인하려면:
            foreach (int num in answer)
            {
                Console.WriteLine(num);
            }
        }
    }
}