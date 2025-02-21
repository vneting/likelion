using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Likelion_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int att = 16755, Mhp = 78103;
            int crt = 36, man = 1017, opp = 41, rpd = 611, end = 22, skl = 39;

            Console.WriteLine("기본 특성");
            Console.WriteLine("  공격력 "+att);
            Console.WriteLine("  최대 생명력 "+Mhp);
            Console.WriteLine("전투 특성");
            Console.WriteLine("  치명 " + crt);
            Console.WriteLine("  특화 " + man);
            Console.WriteLine("  제압 " + opp);
            Console.WriteLine("  신속 " + rpd);
            Console.WriteLine("  인내 " + end);
            Console.WriteLine("  숙련 " + skl);
        }
    }
}
