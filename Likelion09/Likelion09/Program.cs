using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Likelion09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("첫번째 수: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("연산자: ");
            string b = Console.ReadLine();
            Console.Write("두번째 수: ");
            float c = float.Parse(Console.ReadLine());

            if (b == "+")
            {
                Console.WriteLine(a + c);
            }
            else if (b == "-")
            {
                Console.WriteLine(a - c);
            }
            else if (b == "*")
            {
                Console.WriteLine(a * c);
            }
            else if (b == "/")
            {
                if ((a == 0) || (c == 0))
                {
                    Console.WriteLine("답을 낼 수 없습니다.");
                    return;
                }
                Console.WriteLine(a / c);
            }
        }
    }
}
