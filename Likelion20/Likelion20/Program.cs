using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Likelion20
{
    class Marin
    {
        public string Name;
        public int Mineral;

        public Marin()
        {
            Name = "Marin";
            Mineral = 50;
        }
        public Marin(string name, int mineral)
        {
            Name = name;
            Mineral = mineral;
        }
        public void showInfo()
        {
            Console.WriteLine($"이름: {Name}, 가격: {Mineral}");
        }
    }
    class SCV
    {
        public string Name;
        public int Mineral;

        public SCV()
        {
            Name = "SCV";
            Mineral = 50;
        }
        public SCV(string name, int mineral)
        {
            Name = name;
            Mineral = mineral;
        }
        public void showInfo()
        {
            Console.WriteLine($"이름: {Name}, 가격: {Mineral}");
        }
    }
    class Barrack
    {
        public string Name;
        public int MIneral;
        public Barrack()
        {
            Name = "Barrack";
            MIneral = 150;
        }
        public Barrack(string name, int mIneral)
        {
            Name = name;
            MIneral = mIneral;
        }
        public void showInfo()
        {
            Console.WriteLine($"이름: {Name}, 가격: {MIneral}");
        }
    }
    class MineralField
    {
        public int Deploy, Amount;

        public MineralField()
        {
            Deploy = 7;
            Amount = 1500;
        }
        public MineralField(int deploy, int amount)
        {
            Deploy = deploy;
            Amount = amount;
        }
        public void Deploying()
        {
            for(int i = 0; i < Deploy; i++)
            {
                Console.WriteLine($"Deployed Mineral Field. Initial Amount: {Amount}");
            }
        }
    }
    class Game
    {
        public static int mineral;
        public static int gas;
        public static int population;
        public static void showInfo()
        {
            Console.WriteLine($"Mineral: {mineral}, Gas: {gas}, Population: 0/{population}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Game.mineral = 50;
            Game.gas = 0;
            Game.population = 10;


            Marin u1 = new Marin();
            SCV u2 = new SCV();
            Barrack c1 = new Barrack();
            MineralField m1 = new MineralField();

            u1.showInfo();
            u2.showInfo();
            c1.showInfo();
            m1.Deploying();
            Game.showInfo();
        }
    }
}
