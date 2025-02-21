using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace loading
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("□□□□□□□□□□□");
            Thread.Sleep(3000); //1000 = 1sec
            Console.Clear();
            Console.WriteLine("■□□□□□□□□□□");Thread.Sleep(800);Console.Clear();
            Console.WriteLine("■■□□□□□□□□□");Thread.Sleep(800);Console.Clear();
            Console.WriteLine("■■■□□□□□□□□");Thread.Sleep(800);Console.Clear();
            Console.WriteLine("■■■■□□□□□□□");Thread.Sleep(800);Console.Clear();
            Console.WriteLine("■■■■■□□□□□□");Thread.Sleep(800);Console.Clear();
            Console.WriteLine("■■■■■■□□□□□");Thread.Sleep(800);Console.Clear();
            Console.WriteLine("■■■■■■■□□□□");Thread.Sleep(800);Console.Clear();
            Console.WriteLine("■■■■■■■■□□□");Thread.Sleep(800);Console.Clear();
            Console.WriteLine("■■■■■■■■■□□");Thread.Sleep(800);Console.Clear();
            Console.WriteLine("■■■■■■■■■■□");Thread.Sleep(800);Console.Clear();
            Console.WriteLine("■■■■■■■■■■■");*/

            int length = 10, loading, speed = 1000, a, b;

            
            for(a = 0; a < length; a++)
            {
                loading = length - a;
                for (b = 0; b < a+1; b++)
                {
                    Console.Write("■");
                }

                for (b = 0; b < loading-1; b++)
                {
                    Console.Write("□");
                }
                Thread.Sleep(speed);
                if (loading > 1)
                {
                    Console.Clear();
                }
                speed = speed - (a + 1) * 70;
            }

            Console.WriteLine();
            Console.WriteLine("업데이트 완료.");
            
        }
    }
}
