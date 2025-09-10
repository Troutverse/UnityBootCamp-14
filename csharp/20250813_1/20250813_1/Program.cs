namespace _20250813_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckId("Hong GilDong", "hong gildong"));
            Console.WriteLine(CheckId("Kim", "lee"));
        }
        public static string CheckId(string newId, string oldId)
        {
            if (newId.Replace(" ", "-").ToLower().CompareTo(oldId.Replace(" ", "-").ToLower()) == 0) return "중복";
            return "사용 가능";
        }
    }
}