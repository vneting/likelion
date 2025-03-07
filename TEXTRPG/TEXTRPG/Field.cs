using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG
{
    class Field
    {
        Player m_pPlayer = null;
        // 몬스터
        Monster m_pMonster = null;

        public void setPlayer(ref Player pPlayer) { m_pPlayer = pPlayer; }

        public void Progress()
        {
            //사냥터 입장
            int iInput = 0;

            while(true)
            {
                Console.Clear();

                m_pPlayer.Render();
                DrawMap();

                iInput = int.Parse(Console.ReadLine());

                if (iInput == 4) break;

                if (iInput <= 1)
                {
                    CreateMonster(iInput);
                    Fight();
                }
            }
        }

        public void Create(string _strName, int _iHp, int _iAttack, out Monster pMonster)
        {
            pMonster = new Monster();
            INFO tMonster = new INFO();

            tMonster.strName = _strName;
            tMonster.iAttack = _iAttack;
            tMonster.iHp = _iHp;

            pMonster.setMonster(tMonster);
        }

        public void CreateMonster(int input)
        {
            switch (input)
            {
                case 1:
                    Create("비기너 몹", 30, 3, out m_pMonster);
                    break;
                case 2:
                    Create("메이저 몹", 60, 6, out m_pMonster);
                    break;
                case 3:
                    Create("프로퍼 몹", 90, 9, out m_pMonster);
                    break;
            }
        }
        
        public void Fight()
        {
            int iInput = 0;

            while (true)
            {
                Console.Clear();
                m_pPlayer.Render();
                m_pMonster.Render();

                Console.WriteLine("1.공격 2.도망");
                iInput = int.Parse(Console.ReadLine());

                if (iInput == 1)
                {
                    m_pPlayer.SetDamage(m_pMonster.getMonster().iAttack);
                    m_pMonster.setDamage(m_pPlayer.GetINFO().iAttack);

                    if (m_pPlayer.GetINFO().iHp <= 0)
                    {
                        m_pPlayer.SetHp(100);
                        break;
                    }
                }

                if (iInput == 2 || m_pMonster.getMonster().iHp <= 0)
                {
                    m_pMonster = null;
                    break;
                }
            }
        }

        private static void DrawMap()
        {
            Console.WriteLine("1. 비기너");
            Console.WriteLine("2. 메이저");
            Console.WriteLine("3. 프로퍼");
            Console.WriteLine("4. 전단계");
            Console.WriteLine("======================");
            Console.WriteLine("맵을 선택하세요.");
        }

        public Field() { }
        ~Field() { }
    }
}
