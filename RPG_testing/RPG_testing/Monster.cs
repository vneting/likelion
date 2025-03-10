using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_testing
{
    class Monster
    {
        INFO monsterInfo = new INFO();

        public void getDamaged(int amount) { monsterInfo.Health -= amount; }

        public void setMonster(INFO tmonster) { monsterInfo = tmonster; }
        public void render()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("몬스터 이름 : " + monsterInfo.Name);
            Console.WriteLine("체력 : " + monsterInfo.Health + "\t공격력 :  " + monsterInfo.Attack);
        }
    }
}
