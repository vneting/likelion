using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Likelion15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iArray = new int[25];

            for (int i = 0; i < 25; i++)
            {
                iArray[i] = i + 1;
            }

            Random rand = new Random();
            //셔플
            for (int i = 0; i < 100; i++)
            {
                int iA = rand.Next(0, 25);
                int iB = rand.Next(0, 25);
                int iT = 0;


                iT = iArray[iA];
                iArray[iA] = iArray[iB];
                iArray[iB] = iT;
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(iArray[i*5+j].ToString("D2") + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 100; i++)
            {

            }
        }
    }
}
