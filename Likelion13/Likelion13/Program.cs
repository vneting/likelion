using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Likelion13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(35, 15);
            Console.SetBufferSize(35, 15);
            Console.CursorVisible = false;

            int[] number = new int[3];
            int count = 0;
            Random rand = new Random();

            Console.SetCursorPosition(13, 7);
            Console.WriteLine("$LOT MACHINE");
            Console.ReadKey();

            while (true)
            {
                bool[] locked = new bool[3];
                while (true)
                {
                for (int i = 0; i < 3; i++)
                {
                    if (!locked[i])
                    {
                        number[i] = rand.Next(1, 8);
                    }
                }

                Console.SetCursorPosition(3, 5);
                Console.WriteLine("┏━━━━━━┓   ┏━━━━━━┓   ┏━━━━━━┓");
                Console.SetCursorPosition(3, 6);
                Console.WriteLine("┃      ┃   ┃      ┃   ┃      ┃");
                Console.SetCursorPosition(3, 7);
                Console.WriteLine($"┃   {number[0]}  ┃   ┃   {number[1]}  ┃   ┃   {number[2]}  ┃");
                Console.SetCursorPosition(3, 8);
                Console.WriteLine("┃      ┃   ┃      ┃   ┃      ┃");
                Console.SetCursorPosition(3, 9);
                Console.WriteLine("┗━━━━━━┛   ┗━━━━━━┛   ┗━━━━━━┛");

                if (locked[0] && locked[1] && locked[2])
                {
                    break;
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    for (int i = 0; i < 3; i++)
                    {
                        if (!locked[i])
                        {
                            locked[i] = true;
                            break;
                        }
                    }
                }

                Thread.Sleep(50);
                }

                count = 0;
                if (number[0] == number[1]) count++;
                if (number[1] == number[2]) count++;
                if (number[0] == number[2]) count++;

                Console.SetCursorPosition(14, 12);
                if (count == 0) Console.WriteLine("YOU LOSE");
                if (count == 1) Console.WriteLine("  PAIR");
                if (count > 1) Console.WriteLine("☆JACK POT☆");

                Console.SetCursorPosition(15, 14);
                Console.WriteLine("RETRY?");

                Console.ReadKey();
                Console.Clear();
            }
            
        }
    }
}
