using System;

namespace Winform_bai_2_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            Animal cat = new Cat();

            Animal[] animals = new Animal[3];

            animals[0] = dog;
            animals[1] = cat;

            foreach (Animal animal in animals)
            {

            }

            Console.ReadKey();
        }
    }
}
