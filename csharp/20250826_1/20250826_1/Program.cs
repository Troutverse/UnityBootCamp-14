#define TEST

using System.Diagnostics;
using System.Reflection;


namespace Reflection
{
    // Reflection = 클래스용 X-ray 촬영
    // 자주 사용하지 않음 - 그냥 개념을 알고 있으면 됨

    // Attribute

    // 이 클래스는 몬스터 클래스이다!
    class Important : Attribute
    {
        public string message;

        public Important(string message)
        {
            this.message = message;
        }

    }

    [Important("이건 중요한 메시지야, 니가 런타임에 확인해")]
    class Monster
    {
        public static void Test()
        {
            Test2();
        }

        [Conditional("TEST")]
        static void Test2()
        {
            Console.WriteLine("Test가 호출됨");
        }

        public int hp;
        protected int atk;
        private float speed;
    }

    class Program
    {
        static void Main()
        {
            Monster.Test();

            int? A = null;

            int B = A ?? 33;

            Console.WriteLine(A + " " + B);

            //Monster monster = new Monster();
            //Type type = monster.GetType();
            //var fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);
            //foreach (var field in fields)
            //{
            //    string access = "protected";

            //    if (field.IsPublic == true)
            //        access = "public";
            //    else if (field.IsPrivate == true)
            //        access = "priavte";

            //    Console.WriteLine($"{access} {field.FieldType.Name} {field.Name}");
            //}

            //var attributes = type.GetCustomAttributes();
            //foreach (var attribute in attributes)
            //{
            //    Important important = attribute as Important;
            //    if (important != null)
            //    {
            //        Console.WriteLine(important.message);
            //    }
            //}
        }
    }
}