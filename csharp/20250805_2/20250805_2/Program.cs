namespace _20250805_2
{
    class Program
    {
        struct Mage
        {
            public int hp;
        }

        public class Knight
        {
            public int hp;
        }

        static void RecoverKnight(Knight knight)
        {
            knight.hp += 10;
        }
        static void RecoverMage(ref Mage mage)
        {
            mage.hp += 10;
        }

        static void Main()
        {
            /*
                시작 체력은 둘 다 50
                둘다 함수를 통해 HP 가 100 이 되도록 만들어주세요.
                단, 리커버리는 한번에 10씩 회복가능 10 이상은 불가
                함수의 호출은 단 한번
                반복문을 사용해서 100이 되게끔 설계 해주세요.
             */

            Knight knight = new Knight { hp = 50 };
            Mage mage = new Mage { hp = 50 };

            while (knight.hp < 100)
            {
                RecoverKnight(knight);
                RecoverMage(ref mage);
            }

            Console.WriteLine("[Recovery End]");
            Console.WriteLine($"Knight HP: {knight.hp}");
            Console.WriteLine($"Mage HP: {mage.hp}");
        }
    }
}
