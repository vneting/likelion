using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Likelion21
{
    /*class Person
    {
        private string name;

        public void setName(string newName)
        {
            name = newName;
        }
        public string getName()
        {
            return name;
        }

    }*/
    /*class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }*/
    class Person
    {
        public string Name { get;  set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();

            p1.Name = "Hong";
            Console.WriteLine(p1.Name);
        }
    }
}
