using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligate
{

    class Program
    {
        delegate void messageHandler(string message);

        static void DisplayMessage(string message)
        {
            Console.WriteLine($"메세지: {message}");
        }

        static void DisplayUpperMessage(string message)
        {
            Console.WriteLine($"대문자 변형 메세지: {message.ToUpper()}");
        }
        static void Main(string[] args)
        {
            messageHandler messageHandler = DisplayMessage;

            messageHandler("hello");

            messageHandler += DisplayUpperMessage;

            messageHandler("hello, too");

            messageHandler = null;

            messageHandler = DisplayMessage;

            messageHandler("yes?");
        }
    }
}
