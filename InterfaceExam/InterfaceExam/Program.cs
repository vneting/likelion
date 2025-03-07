using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExam
{
    interface IAnimal
    {
        void speak();
    }

    class Dog : IAnimal
    {
        public void speak()
        {
            Console.WriteLine("Bark");
        }
    }
    class Cat : IAnimal
    {
        public void speak()
        {
            Console.WriteLine("Meow");
        }
    }
    class AnimalTrainer
    {
        public void Train(IAnimal animal)
        {
            Console.Write("동물이 소리를 냅니다. ");
            animal.speak();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AnimalTrainer trainer = new AnimalTrainer();

            IAnimal myDog = new Dog();
            IAnimal myCat = new Cat();

            trainer.Train(myDog);
            trainer.Train(myCat);
        }
    }
}
