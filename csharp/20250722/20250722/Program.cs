using System;

namespace _20250722
{
    class Master
    {
        static void Main(string[] args)
        {
            #region 20250722
            // 프로그램 실행 과정 SSD -> RAM -> CPU
            #endregion
            #region 20250729
            Console.Write("==========================\n[직업을 선택하세요]\n==========================\n1. 전사, 2. 법사, 3. 도둑\n번호를 입력하세요 : " );
            int Chr = int.Parse(Console.ReadLine());
            if (Chr == 1)
            {
                Console.WriteLine("전사를 선택하셨습니다.");
            }
            else if (Chr == 2)
            {
                Console.WriteLine("법사를 선택하셨습니다.");
            }
            else if (Chr == 3)
            {
                Console.WriteLine("도둑을 선택하셨습니다.");
            }
            else
            {
                Console.WriteLine("해당 직업이 없습니다.");
            }
            #endregion
        }
    }
}