using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action1
{
    class Program
    {
        static void SayHello()
        {
            Console.WriteLine("Hello");
        }
        static void ShowNotification()
        {
            Console.WriteLine("Alram coming");
        }

        static void HelloWorld(string message)
        {
            Console.WriteLine("New message " + message);
        }
        static void Main(string[] args)
        {
            Action sayHello = SayHello;
            sayHello();

            sayHello += ShowNotification;

            sayHello?.Invoke();

            Action<string> h = null;

            h += HelloWorld;
            h?.Invoke("this is action, boy");

            Action noti = null;
            noti += () => Console.WriteLine("and this is not source action");

            noti?.Invoke();

            Action<int> square = number => Console.WriteLine(number * number);

            square(5);
        }
    }
}
