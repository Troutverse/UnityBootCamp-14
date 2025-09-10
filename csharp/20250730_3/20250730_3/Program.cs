namespace _20250730_3
{
    public class Player
    {
        public string HERO { get; protected set; }
        public int HP { get; protected set; }
        public int ATK { get; protected set; }

        public Player(string name, int hp, int atk)
        {
            HERO = name;
            HP = hp;
            ATK = atk;
        }
    }
    public class Monster
    {
        public string MON { get; protected set; }
        public int HP { get; protected set; }
        public int ATK { get; protected set; }

        public Monster(string name, int hp, int atk)
        {
            MON = name;
            HP = hp;
            ATK = atk;
        }
    }
    internal class Program
    {
        public static (string HERO, int HP, int ATK) HeroSelect()
        {
            while (true) 
            { 
                string? INPUT;
                Console.Write("직업을 선택하세요!\n[1] 전사\n[2] 마법사\n[3] 도둑\n");
                INPUT = Console.ReadLine();
                if (INPUT == "1")
                {
                    Console.WriteLine($"Hero : Warrior HP : 100 ATK : 10 ");
                    return ("Warrior", 100, 10);
                }
                else if (INPUT == "2")
                {
                    Console.WriteLine($"Hero : Mage HP : 70 ATK : 15 ");
                    return ("Mage", 70, 15);
                    }
                else if (INPUT == "3")
                {
                    Console.WriteLine($"Hero : Thief HP : 80 ATK : 12 ");
                    return ("Thief", 80, 12);
                }
            }
        }
        public static (string HERO, int HP, int ATK) SpwanMonster(int RMoster)
        {
            if (RMoster == 0)
            {
                Console.WriteLine("스켈레톤이 스폰되었습니다.\r\n스켈레톤 HP 30 ATK 3");
                return ("Skeleton", 100, 10);
            }
            else if (RMoster == 1)
            {
                Console.WriteLine("슬라임이 스폰되었습니다.\r\n슬라임 HP 20 ATK 2");
                return ("Slime", 100, 10);
            }
            else
            {
                Console.WriteLine("오크가 스폰되었습니다.\r\n오크 HP 40 ATK 4");
                return ("Oak", 100, 10);
            }

        }
        public static int GameStage1()
        {

            string? INPUT;
            Console.Write("게임에 접속했습니다.\n[1] 사냥터로 이동\n[2] 로비로 돌아가기");
            INPUT = Console.ReadLine();
            if (INPUT == "1") return 1;
            else if (INPUT == "2") return 2;
            else return GameStage1();
        }
        public static int GameStage2()
        {
            string? INPUT;
            Console.Write("[1] 전투 시작\n[2] 도망가기");
            INPUT = Console.ReadLine();
            if (INPUT == "1") return 1;
            else if (INPUT == "2") return 2;
            else return GameStage2();

        }
        
        static void Main(string[] args)
        {
            Random Random = new Random();
            int Stage, Stage2;
            
            while (true)
            {
                var (PlayerName, PlayerHP, PlayerATK) = HeroSelect();
                Player Player = new Player(PlayerName, PlayerHP, PlayerATK);
                Stage = GameStage1();
                if (Stage == 1)
                {
                    var (MonsterName, MonsterHP, MonsterATK) = SpwanMonster(Random.Next(4));
                    Monster Monster = new Monster(MonsterName, MonsterHP, MonsterATK);
                    Stage2 = GameStage2();
                }
                else if (Stage == 2) continue;
            }
        }
     }
}
