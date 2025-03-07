using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Likelion10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("당신의 캐릭터를 선택하세요.(1.검사 2.마법사 3.도적");
            //int num = int.Parse(Console.ReadLine());

            //Console.Clear();

            //switch (num)
            //{
            //    case 1:
            //        Console.WriteLine("검사");
            //        Console.WriteLine("공격력 100");
            //        Console.WriteLine("방어력 90");
            //        break;
            //    case 2:
            //        Console.WriteLine("마법사");
            //        Console.WriteLine("공격력 110");
            //        Console.WriteLine("방어력 80");
            //        break;
            //    case 3:
            //        Console.WriteLine("도적");
            //        Console.WriteLine("공격력 115");
            //        Console.WriteLine("방어력 70");
            //        break;
            //}

            int cls = 4, rnd = 0, ch = 5;
            Random rand = new Random();

            while(cls > 1)
            {
                Console.WriteLine("현재 강화 확률은 {0}", cls * ch);
                Console.ReadKey();
                
                rnd = rand.Next(0, 100);
                if (rnd < cls*ch)
                {
                    --cls;
                    Console.WriteLine("강화 성공!");
                } else
                {
                    Console.WriteLine("실패!");
                }
            }


        }
    }
}
