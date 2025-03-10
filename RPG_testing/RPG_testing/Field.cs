using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_testing
{
    class Field
    {
        Player pPlayer = null;
        Monster pMonster = null;

        public void setPlayer(ref Player player) { pPlayer = player; }

        public void Progress()
        {
            int input = 0;

            while (true)
            {
                Console.Clear();

                pPlayer.Render();

            }
        }
    }
}
