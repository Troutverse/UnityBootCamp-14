namespace _20250812_2
{// [1] 추상화: 공통 속성과 기능을 정의한 추상 클래스
    abstract class Player
    {
        // [4] 캡슐화: 내부 데이터는 외부에서 직접 접근 불가능
        private int hp;
        private int mp;

        public void Test(int a)
        {
            hp = a;
        }

        public void Attack()
        {
            Console.WriteLine("공격!");
        }

        public void Defend()
        {
            Console.WriteLine("방어!");
        }

        // [3] 다형성: 하위 클래스에서 다르게 구현할 메서드
        public abstract void UseSpecialSkill();

        // [4] 캡슐화: 공개된 메서드를 통해서만 접근
        public void TakeDamage(int amount)
        {
            hp -= amount;
            Console.WriteLine($"[피해] {amount} 만큼 피해를 입음! 현재 HP: {hp}");
        }
    }

    // [2] 상속: Player 추상 클래스 상속받음
    class Knight : Player
    {
        // [3] 다형성: 스킬 다르게 구현
        public override void UseSpecialSkill()
        {
            Console.WriteLine("방패치기!");
        }
    }

    // [2] 상속: Player 추상 클래스 상속받음
    class Mage : Player
    {
        // [3] 다형성: 스킬 다르게 구현
        public override void UseSpecialSkill()
        {
            Console.WriteLine("파이어볼!");
        }
    }

    // [2] 상속: Player 추상 클래스 상속받음
    class Archer : Player
    {
        // [3] 다형성: 스킬 다르게 구현
        public override void UseSpecialSkill()
        {
            Console.WriteLine("화살 연사!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}