using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_testing
{
    class Player
    {
        int input = 0;

        public INFO playerInfo;
        public void Initialize()
        {
            playerInfo = new INFO();
            ChooseJob();
        }

        public void ChooseJob()
        {
            Console.WriteLine("=================================================");
            Console.WriteLine("Choose your job. (1.Worrior 2.Magician 3.Rogue)");
            input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    playerInfo.Name = "Worrior";
                    playerInfo.Health = 100;
                    playerInfo.Attack = 10;
                    break;
                case 2:
                    playerInfo.Name = "Magician";
                    playerInfo.Health = 80;
                    playerInfo.Attack = 15;
                    break;
                case 3:
                    playerInfo.Name = "Rogue";
                    playerInfo.Health = 85;
                    playerInfo.Attack = 13;
                    break;
            }

        }
        public void getDamaged(int amount) { playerInfo.Health -= amount; }
        public void Render()
        {
            Console.WriteLine("=================================================");
            Console.WriteLine($"Name:{playerInfo.Name}");
            Console.WriteLine($"Health:{playerInfo.Health} Attack:{playerInfo.Attack}");
        }

        public INFO getInfo() { return playerInfo; }

        public void setHealth(int hp) { playerInfo.Health = hp; }
    }
}
