using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_testing
{
    class GameManager
    {
        Player player = null;
        Field field = null;

        public void Initialize()
        {
            player = new Player();
            player.Initialize();
        }
        public void Progress()
        {
            int input = 0;

            while (true)
            {
                Console.Clear();

                player.Render();
                Console.WriteLine("What would you do? (1.Hunting 2.Exit)");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.Clear();

                    player.Render();
                    Console.WriteLine("1.Begginer");
                    Console.WriteLine("2.Minor");
                    Console.WriteLine("3.Major");
                    Console.WriteLine("4.Back");
                    Console.WriteLine("=================================================");
                    Console.Write("Choose map: ");
                    input = int.Parse(Console.ReadLine());

                    field = new Field();
                }

                if (input == 2) break;
            }
        }
    }
}
