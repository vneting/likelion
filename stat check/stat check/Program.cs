using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stat_check
{
    class Program
    {
        static void Main(string[] args)
        {
            float skd, cgg, ud, Mm, bmr, nbmr, sp, vsp, csp, srr;

            Console.Write("당신의 루인 스킬 피해는? ");
            skd = float.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("당신의 카드 게이지 획득량은? ");
            cgg = float.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("당신의 각성기 피해는? ");
            ud = float.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("당신의 최대 마나는? ");
            Mm = float.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("당신의 전투 중 마나 회복량은? ");
            bmr = float.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("당신의 비전투 중 마나 회복량은? ");
            nbmr = float.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("당신의 이동속도는? ");
            sp = float.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("당신의 탈 것 속도는? ");
            vsp = float.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("당신의 운반 속도는? ");
            csp = float.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("당신의 스킬 재사용 대기시간 감소는? ");
            srr = float.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("당신의 활동 스킬 스탯");
            Console.WriteLine(" 루인 스킬 피해 " + skd + "%");
            Console.WriteLine(" 카드 게이지 획득량 " + cgg + "%");
            Console.WriteLine(" 각성기 피해 " + ud + "%");
            Console.WriteLine(" 최대 마나 " + Mm);
            Console.WriteLine(" 전투 중 마나 회복량 " + bmr);
            Console.WriteLine(" 비 전투 중 마나 회복량 " + nbmr);
            Console.WriteLine(" 이동 속도 " + sp + "%");
            Console.WriteLine(" 탈 것 속도 " + vsp + "%");
            Console.WriteLine(" 운반 속도 " + csp + "%");
            Console.WriteLine(" 스킬 재사용 대기시간 감소 " + srr + "%");

        }
    }
}
