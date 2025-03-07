using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Likelion19
{
    class Program
    {
        static string[] itemName = new string[100];
        static int[] itemValue = new int[100];
        static int maxSize = 100;

        static void addItem(string name, int value)
        {
            for (int i = 0; i < maxSize; i++)
            {
                if (itemName[i] == null)
                {
                    itemName[i] = name;
                    itemValue[i] = value;
                    return;
                } else if (itemName[i] == name)
                {
                    itemValue[i] += value;
                }
            }
            Console.WriteLine("인벤토리에 빈 공간이 없습니다");
            return;
        }

        static void removeItem(string name, int value)
        {
            for (int i = 0; i < maxSize; i++)
            {
                if (itemName[i] == name)
                {
                    if (itemValue[i] > value)
                    {
                        Console.WriteLine($"{name}을 {value}개 만큼 버렸습니다");
                        itemValue[i] -= value;
                        return;
                    }
                    else if (itemValue[i] == value)
                    {
                        Console.WriteLine($"{name}을 전부 버렸습니다");
                        itemName[i] = null;
                        itemValue[i] = 0;
                    }
                    else Console.WriteLine($"{name}이 충분하지 않습니다");
                    
                }
            }
            Console.WriteLine($"{name}은 인벤토리에 없습니다");
            return;
        }

        static void showInventory()
        {
            bool hasItem = false;
            for (int i = 0; i < maxSize; i++)
            {
                if (itemName[i] != null)
                {
                    Console.WriteLine($"- {itemName[i]} (갯수: {itemValue[i]})");
                    hasItem = true;
                }
            }
            if (!hasItem)
            {
                Console.WriteLine("인벤토리가 비어 있습니다.");
            }
        }

        static void Main()
        {
            addItem("철검", 1);
            addItem("방패", 1);
            addItem("물약", 5);

            showInventory();

            removeItem("물약", 2);
            removeItem("활", 1);
            showInventory();
        }
    }

}
