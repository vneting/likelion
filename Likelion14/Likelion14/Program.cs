using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Likelion14
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] st = new string[3] { "00. 김예지", "01. 박종수", "02. 이유지" };
            string[] ty = new string[3] { "국어", "영어", "수학" };
            int[,] point = new int[st.Length, ty.Length];
            int i, j, res = 0;
            for (i = 0; i < st.Length; i++)
            {
                Console.WriteLine($"{st[i]} 학생 점수");

                for (j = 0; j < ty.Length; j++)
                {
                    Console.Write($"{ty[j]}: ");
                    point[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.Clear();

            for (i = 0; i < st.Length; i++)
            {
                res = 0;
                Console.WriteLine($"{st[i]} 학생 점수 기록");

                for (j = 0; j < ty.Length; j++)
                {
                    Console.WriteLine($"{ty[j]}: {point[i,j]}");
                    res = res + point[i, j];
                }
                Console.WriteLine($"총점: {res}");
                Console.WriteLine($"평균: {res/ty.Length}");
                Console.WriteLine();
            }
        }
    }
}
