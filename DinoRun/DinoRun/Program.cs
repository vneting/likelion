using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

class Player
{
    [DllImport("msvcrt.dll")]
    static extern int _getch();
    public int Y { get; private set; }
    public int Score { get; private set; } = 0;
    private int jumpState = 0;
    private bool isJumping = false;

    public Player()
    {
        Y = Console.WindowHeight - 5;
    }

    public void UpdateGame(Floor flooring, List<Wall> walls)
    {
        Console.Clear();
        flooring.drawFloor();
        DrawScore();
        foreach (Wall wall in walls) wall.Draw();
        DrawPlayer();
    }

    public void HandleJump()
    {
        if (!isJumping && Console.KeyAvailable)
        {
            int key = _getch();
            if (key == 72 || key == 32 || key == 119)
            {
                isJumping = true;
                jumpState = 1;
            }
        }

        if (isJumping)
        {
            if (jumpState < 6) Y--; // 상승
            else if (jumpState < 21) { } // 체공
            else if (jumpState < 26) Y++; // 하강
            else
            {
                isJumping = false;
                jumpState = 0;
            }

            jumpState++;
        }
    }

    public void DrawPlayer()
    {
        string[] player = { "    ■■■□", "■■■■■□□■", "■■■■■■■■", "    ◎    ◎" };
        for (int i = 0; i < player.Length; i++)
        {
            Console.SetCursorPosition(15, Y + i);
            Console.Write(player[i]);
        }
    }

    public void AddScore(int value)
    {
        Score += value;
    }

    private void DrawScore()
    {
        Console.SetCursorPosition(Console.WindowWidth - 17, 0);
        Console.Write("┏━━━━━━━━━━━━━━┓");
        Console.SetCursorPosition(Console.WindowWidth - 17, 1);
        Console.Write($"┃ Score : {Score,5}┃");
        Console.SetCursorPosition(Console.WindowWidth - 17, 2);
        Console.Write("┗━━━━━━━━━━━━━━┛");
    }
}

class Floor
{
    string floor = "";
    Random rand = new Random();

    public void setFloor()
    {
        for (int i = 0; i < 40; i++) floor += GetRandomBlock();
    }

    public void moveFloor()
    {
        floor = floor.Substring(1) + GetRandomBlock();
    }

    public void drawFloor()
    {
        moveFloor();
        Console.SetCursorPosition(0, Console.WindowHeight - 1);
        Console.Write(floor);
    }

    private char GetRandomBlock()
    {
        char[] blocks = { '■', '□', '●', '○' };
        return blocks[rand.Next(blocks.Length)];
    }
}

class Wall
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public bool HasScored { get; private set; } = false; // 점수 증가 체크

    public Wall(int startX, int startY)
    {
        X = startX;
        Y = startY;
    }

    public void Move()
    {
        X-=2;
    }

    public void Draw()
    {
        for (int i = 0; i < 3; i++) // 3칸짜리 장애물
        {
            Console.SetCursorPosition(X, Y + i);
            Console.Write("■■");
        }
    }

    public bool IsOffScreen()
    {
        return X < 0;
    }

    public bool PassedPlayer()
    {
        if (!HasScored && X < 15) // 플레이어를 지나쳤을 때
        {
            HasScored = true;
            return true;
        }
        return false;
    }

    public bool CollidesWith(Player player)
    {
        bool xCollision = !(X + 1 < 15 || X > 21); // 장애물과 차의 X 범위가 겹치면 충돌
        bool yCollision = (player.Y + 3 >= Y && player.Y <= Y + 2); // 장애물과 Y 좌표가 겹침

        return xCollision && yCollision;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        Console.SetWindowSize(80, 15);
        Console.SetBufferSize(80, 15);

        Player player = new Player();
        Floor floor = new Floor();
        List<Wall> walls = new List<Wall>();
        int lastUpdateTime = Environment.TickCount;
        int lastWallSpawnTime = Environment.TickCount;
        Random rand = new Random();

        floor.setFloor();

        Console.SetCursorPosition(37, 7);
        Console.Write("Car Run");
        Console.ReadKey();
        Console.Clear();

        while (true)
        {
            if (lastUpdateTime + 17 < Environment.TickCount)
            {
                lastUpdateTime = Environment.TickCount;

                // 장애물 생성
                if (Environment.TickCount > lastWallSpawnTime + rand.Next(5000, 6000))
                {
                    walls.Add(new Wall(Console.WindowWidth - 2, Console.WindowHeight - 4));
                    lastWallSpawnTime = Environment.TickCount;
                }

                // 장애물 이동 및 제거
                for (int i = walls.Count - 1; i >= 0; i--)
                {
                    walls[i].Move();

                    // 플레이어가 장애물을 넘었으면 점수 +100
                    if (walls[i].PassedPlayer())
                    {
                        player.AddScore(100);
                    }

                    // 충돌 감지 -> 게임 종료
                    if (walls[i].CollidesWith(player))
                    {
                        Console.Clear();
                        Console.SetCursorPosition(30, Console.WindowHeight / 2);
                        Console.WriteLine("   Game Over!   ");
                        Console.SetCursorPosition(30, Console.WindowHeight / 2 + 1);
                        Console.WriteLine($"Final Score: {player.Score}");
                        return;
                    }

                    if (walls[i].IsOffScreen()) walls.RemoveAt(i);
                }

                player.HandleJump();
                player.UpdateGame(floor, walls);
            }
        }
    }
}
