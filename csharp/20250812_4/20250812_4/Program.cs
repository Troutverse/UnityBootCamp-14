namespace _20250812_4
{
    abstract public class Character
    {
        public string Name;
        public int HP;
        public int ATK;
        public bool isDead = true;
        public Character(string name, int hp, int atk)
        {
            Name = name;
            HP = hp;
            ATK = atk;
        }

        public void Attack(Character target)
        {
            target.HP -= ATK;
            Console.WriteLine($"{Name}의 공격 -> {target.Name} HP : {target.HP}");
        }
        public void IsDead()
        {
            isDead = false;
        }
    }
    class Player : Character
    {
        public int EXP = 0;
        public Player(string name, int hp, int atk) : base(name, hp, atk)
        {
            Name = name;
            HP = hp;
            ATK = atk;
        }
        public void GainExp(int amount)
        {
            EXP += amount;
        }
    }
    class Monster : Character
    {
        public Monster(string name, int hp, int atk) : base(name, hp, atk)
        {
            Name = name;
            HP = hp;
            ATK = atk;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Player player = new Player("Spear Man", 100, 30);
            string input = "";
            while (player.isDead)
            {
                Monster monster = new Monster(RandomName(), rand.Next(20, 51), rand.Next(2, 6));
                Console.WriteLine($"====몬스터 등장!====\n{monster.Name} (HP:{monster.HP}, ATK:{monster.ATK})\n====================\n");
                while (monster.isDead)
                {
                    player.Attack(monster);
                    if (monster.HP <= 0)
                    {
                        Console.WriteLine($"{monster.Name} Down!!\n");
                        monster.IsDead();
                        continue;
                    }
                    monster.Attack(player);
                    if (player.HP <= 0) 
                    {
                        Console.WriteLine($"{player.Name} Down!!\n");
                        break;
                    }
                    Console.WriteLine($"\n현재 HP 상태 {player.Name} : {player.HP}, {monster.Name} : {monster.HP}\n");
                }
                if (player.HP <= 0)
                {
                    player.IsDead();
                    continue;
                }
              
                player.GainExp(10);
                Console.WriteLine($"현재 {player.Name}의 EXP : {player.EXP}");
               
                while (input != "y" && input != "n")
                {
                    Console.WriteLine("Go OR Stop? y/n");
                    input = Console.ReadLine();
                }
                if (input == "y")
                {
                    input = "";
                    continue;
                }
                else
                {
                    input = "";
                    break;
                }

            }
            Console.WriteLine($"{player.Name}의 경험치는 {player.EXP}");
            Console.WriteLine("수고링");
        }

        static public string RandomName()
        {
            Random rand = new Random();
            string[] Monsters = { "Pig", "Wolf", "Bear", "Goblin"};
            return Monsters[rand.Next(0, Monsters.Length)];
        }
    }
}
