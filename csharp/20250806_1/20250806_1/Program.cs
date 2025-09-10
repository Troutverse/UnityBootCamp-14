namespace _20250806_1
{
    class Knight
    {
        public static int count = 0;
        public int id;
        public int hp;

        public Knight()
        {
            id = count++;
            hp = 100;
        }
        public void Info()
        {
            Console.WriteLine($"기사 ID : {id}, 치력 : {hp}");
        }
        public static void ResetCount()
        {
            count = 0;
            Console.WriteLine($"Knight 수 초기화!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Knight knight1 = new Knight();
            knight.Info();
            knight1.Info();
            Console.WriteLine($"현재 Knight 수 : {Knight.count}");
            Knight.ResetCount();
            Console.WriteLine($"현재 Knight 수 : {Knight.count}");
        }
    }
}