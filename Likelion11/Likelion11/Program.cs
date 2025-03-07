using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Likelion11
{
    class Program
    {
        static void Main(string[] args)
        {
            int wood = 0, gain = 0, choose = 0, i;
            Random rand = new Random();

            Console.WriteLine("대장장이 키우기");
            Console.WriteLine("press any button for start");
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("오늘도 열심히 일해야지");
            Console.ReadKey();
            Console.WriteLine("무엇을 해야할까?");
            Console.ReadKey();
            Console.WriteLine();

            while (choose != 3)
            {
                Console.WriteLine("1. 장작패기");
                Console.WriteLine("2. 장비 제련");
                Console.WriteLine("3. 오늘은 이제 쉬자...");
                choose = int.Parse(Console.ReadLine());

                Console.Clear();

                if (choose == 1)
                {
                    for (i = 0; i < 10; i++)
                    {
                        gain = rand.Next(10, 21);
                        Console.WriteLine($"퍽! 장작을 팼다. 나무 {gain}개 획득.");
                        wood = wood + gain;
                    }
                } else if (choose == 2)
                {
                    Console.WriteLine("한 번 재련 할 때마다 나무가 10개 씩 필요하다.");
                    Console.WriteLine($"재련 좀 해볼까? 보유 장작 개수: {wood}");
                    Console.ReadKey();
                    Console.WriteLine();
                    Console.WriteLine("1. 그래 해보자.");
                    Console.WriteLine("2. 다음 기회에..");
                    Console.WriteLine("3. 오늘은 이제 쉴까?");
                    choose = int.Parse(Console.ReadLine());

                    if (choose == 1)
                    {
                        while (wood >= 10 && choose == 1)
                        {
                            wood -= 10;
                            gain = rand.Next(0, 100);
                            if (gain < 10)
                            {
                                Console.WriteLine("실패했다...");
                            } else if (gain < 30)
                            {
                                Console.WriteLine("그나마 좀 낫군. B급 획득");
                            } else if (gain < 70)
                            {
                                Console.WriteLine("괜찮군. A급 획득");
                            } else if (gain < 90)
                            {
                                Console.WriteLine("좋았어 걸작이야. S급 획득");
                            } else
                            {
                                Console.WriteLine("이건 역사에 남겠어. SS급 획득");
                            }

                            Console.WriteLine($"한번 더? 보유 장작 개수: {wood}");
                            Console.ReadKey();
                            Console.WriteLine();
                            Console.WriteLine("1. 그래 해보자.");
                            Console.WriteLine("2. 다음 기회에..");
                            Console.WriteLine("3. 오늘은 이제 쉴까?");
                            choose = int.Parse(Console.ReadLine());

                        }
                        Console.WriteLine("장작이 없어...");
                    }

                    Console.WriteLine("이제 자러가자.");
                }
            }

        }
    }
}
