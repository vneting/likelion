using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG
{
    class Monster
    {
        public INFO m_tMonster; //몬스터 데이터

        public void setDamage(int iAttack) { m_tMonster.iHp -= iAttack; }
        public void setMonster(INFO tMonster) { m_tMonster = tMonster; }
        public INFO getMonster() { return m_tMonster; }

        public void Render()
        {
            Console.WriteLine("===========================");
            Console.WriteLine($"몬스터 이름: {m_tMonster.strName}");
            Console.WriteLine($"체력: {m_tMonster.iHp} 공격력: {m_tMonster.iAttack}");
        }

        public Monster() { }

        ~Monster() { }
    }
}
