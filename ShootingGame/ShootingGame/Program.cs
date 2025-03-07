using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ShootingGame
{
    public class BULLET
    {
        public int x;
        public int y;
        public bool isFire;
    }
    public class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();

        public int playerX;
        public int playerY;
        public BULLET[] playerBullet = new BULLET[20];
        public BULLET[] playerBullet2 = new BULLET[20];
        public BULLET[] playerBullet3 = new BULLET[20];
        public int Score = 0;
        public Item item = new Item();
        public int itemCount = 0;



        public Player()
        {
            playerX = 0;
            playerY = 12;

            for ( int i = 0; i < 20; i++ )
            {
                playerBullet[i] = new BULLET();
                playerBullet[i].x = 0;
                playerBullet[i].y = 0;
                playerBullet[i].isFire = false;
            
                playerBullet2[i] = new BULLET();
                playerBullet2[i].x = 0;
                playerBullet2[i].y = 0;
                playerBullet2[i].isFire = false;
            
                playerBullet3[i] = new BULLET();
                playerBullet3[i].x = 0;
                playerBullet3[i].y = 0;
                playerBullet3[i].isFire = false;
            }
        }
        public void GameManager()
        {
            KeyControl();
            PlayerDraw();
            BulletDraw();
            UIScore();
            if(item.ItemLife)
            {
                item.ItemDraw();
                item.ItemMove();

                CrashItem();
            }
        }

        public void PlayerDraw()
        {
            string[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            };

            for (int i = 0; i < player.Length; i++)
            {
                Console.SetCursorPosition(playerX, playerY + i);
                Console.Write(player[i]);
            }
        }

        public void BulletDraw()
        {
            string bullet = "->";

            for(int i=0; i<20; i++)
            {
                if (playerBullet[i].isFire == true)
                {
                    Console.SetCursorPosition(playerBullet[i].x - 1, playerBullet[i].y + 1);

                    Console.Write(bullet);

                    playerBullet[i].x++;

                    if (playerBullet[i].x > 77)
                    {
                        playerBullet[i].isFire = false;
                    }
                }
            }
        }

        public void Crash(Enemy enemy)
        {
            for (int i = 0; i < 20; i++)
            {
                if (playerBullet[i].isFire == true)
                {
                    if (playerBullet[i].y == enemy.y-1)
                    {
                        if ((playerBullet[i].x >= enemy.x-1) && (playerBullet[i].x <= enemy.x+1) )
                        {
                            Random rand = new Random();
                            enemy.x = 75;
                            enemy.y = rand.Next(2, 22);

                            playerBullet[i].isFire = false;
                        }
                    }
                }
            }
        }

        public void KeyControl()
        {
            int pressKey;

            if(Console.KeyAvailable)
            {
                pressKey = _getch();

                if (pressKey == 0 || pressKey == 224) // 화살표 키 또는 특수 키 감지
                {
                    pressKey = _getch(); // 실제 키 값 읽기
                }

                switch (pressKey)
                {
                    case 72:
                        {
                            playerY--;
                            if (playerY < 1) playerY = 1;
                            break;
                        }
                    case 75:
                        {
                            playerX--;
                            if (playerX < 0) playerX = 1;
                            break;
                        }
                    case 77:
                        {
                            playerX++;
                            if (playerX > 75) playerX = 75;
                            break;
                        }
                    case 80:
                        {
                            playerY++;
                            if (playerY > 23) playerY = 23;
                            break;
                        }
                    case 32:
                        {
                            for(int i = 0; i< 20; i++)
                            {
                                if (playerBullet[i].isFire == false)
                                {
                                    playerBullet[i].isFire = true;
                                    playerBullet[i].x = playerX + 5;
                                    playerBullet[i].y = playerY;
                                    break;
                                }
                            }
                            break;
                        }
                }

            }
        }

        public void UIScore()
        {
            Console.SetCursorPosition(63, 0);
            Console.Write("┏━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(63, 1);
            Console.Write("┃              ┃");
            Console.SetCursorPosition(65, 1);
            Console.Write("Score : " + Score);
            Console.SetCursorPosition(63, 2);
            Console.Write("┗━━━━━━━━━━━━━━┛");
        }

        public void CrashItem()
        {
            for(int i = 0; i < playerBullet.Length; i++)
            {
                if (playerBullet[i].x >= item.x+1 || playerBullet[i].x <= item.x-1)
                {
                    
                }
            }
        }
        
    }
    public class Enemy
    {
        public int x;
        public int y;

        public Enemy()
        {
            x = 77;
            y = 12;
        }

        public void EnemyDraw()
        {
            string enemy = "<-0->";
            Console.SetCursorPosition(x, y);
            Console.Write(enemy);
        }

        public void EnemyMove()
        {
            Random rand = new Random();
            x--;

            if(x < 2)
            {
                x = 77;
                y = rand.Next(2, 22);
            }

        }
    }
    public class Item 
    {
        public string ItemName;
        public string ItemSprite;
        public int x;
        public int y;
        public bool ItemLife = false;

        public void ItemDraw()
        {
            Console.SetCursorPosition(x, y);
            ItemSprite = "ITEM☆";
            Console.Write(ItemSprite);
        }
        public void ItemMove()
        {
            if(x <= 1 || y <=1)
            {

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 26);
            Console.CursorVisible = false;

            Player player = new Player();
            Enemy enemy = new Enemy();

            int dTime = Environment.TickCount;

            while(true)
            {
                if(dTime + 50 < Environment.TickCount)
                {
                    dTime = Environment.TickCount;
                    Console.Clear();

                    player.GameManager();

                    player.BulletDraw();

                    enemy.EnemyDraw();
                    enemy.EnemyMove();

                    player.Crash(enemy);
                }
            }
        }
    }
}
