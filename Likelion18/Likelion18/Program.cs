using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Likelion18
{
    struct Player
    {
        public int playerX, playerY;
        public Player(int x, int y)
        {
            playerX = x;
            playerY = y;
        }
        
        public void playerMove(int dx, int dy)
        {
            playerX += dx;
            playerY += dy;
        }

        public void playerShow()
        {
            Console.Clear();
            Console.SetCursorPosition(playerX, playerY);
            Console.Write("->");
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            Console.CursorVisible = false;

            Player player = new Player(40, 12);

            ConsoleKey downKey;

            do
            {
                player.playerShow();

                downKey = Console.ReadKey(true).Key;

                switch (downKey)
                {
                    case ConsoleKey.UpArrow: if (player.playerY > 0) player.playerMove(0, -1); break;
                    case ConsoleKey.DownArrow: if (player.playerY < Console.WindowHeight-1) player.playerMove(0, 1); break;
                    case ConsoleKey.LeftArrow: if (player.playerX > 0) player.playerMove(-1, 0); break;
                    case ConsoleKey.RightArrow: if (player.playerX < Console.WindowWidth-1) player.playerMove(1, 0); break;
                }
                Thread.Sleep(16);
            } while (downKey != ConsoleKey.Escape);
            
        }
    }
}
