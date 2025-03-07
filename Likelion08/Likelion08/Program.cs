using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Likelion08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Like Lion RPG");
            Console.WriteLine("Press any button for start");

            Console.Clear();
            Console.Write("가지고 있는 소지금을 입력하세요: ");
            int money = int.Parse(Console.ReadLine());
            int pow = 100; string wep;

            Console.Clear();
            Console.Write("당신의 이름은? ");
            string name = Console.ReadLine();

            if (money > 601)
            {
                wep = "전설의 검";
                pow += 7;
            } else if (money > 501)
            {
                wep = "유령검";
                pow += 6;
            } else if (money > 401)
            {
                wep = "엑스칼리버";
                pow += 5;
            } else if (money > 301)
            {
                wep = "집판검";
                pow += 4;
            } else if (money > 201)
            {
                wep = "진은검";
                pow += 3;
            } else if (money > 101)
            {
                wep = "카타나";
                pow += 2;
            } else
            {
                wep = "무한의 대검";
                pow += 1;
            } 

            Console.Clear();
            Console.WriteLine("당신의 캐릭터");
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"공격력: {pow}");
            Console.WriteLine($"소지무기: {wep}");
        }
    }
}
