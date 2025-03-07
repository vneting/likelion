using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Likelion16
{
    class Program
    {
        static int Max(int a, int b, int c)
        {
            int com = 0;
            if (a > com) com = a;
            if (b > com) com = b;
            if (c > com) com = c;
            return com;
        }
        static void Main(string[] args)
        {
            Console.Write("첫번째 정수: ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("두번째 정수: ");
            int j = int.Parse(Console.ReadLine());
            Console.Write("세번째 정수: ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"가장 큰 수는 {Max(i,j,k)}입니다.");            
        }
    }
}
