public abstract class Monster
{

    public void Move()
    {
        Console.WriteLine("몬스터가 한 칸 이동합니다.");
    }
    public abstract void Attack();

}

public class Orc : Monster
{
    public override void Attack()
    {
        Console.WriteLine("오크가 몽둥이로 공격!");
    }
}

public class Skeleton : Monster
{
    public override void Attack()
    {
        Console.WriteLine("스켈레톤이 화살을 발사!");
    }
}
    internal class Program
{
    static void Main(string[] args)
    {
        new Orc().Move();
        new Orc().Attack();
        new Skeleton().Move();
        new Skeleton().Attack();
    }
}

