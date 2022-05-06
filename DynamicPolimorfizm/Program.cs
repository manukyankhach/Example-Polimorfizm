using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPolimorfizm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Caw());
            animals[1].AnimalSound();
            Console.ReadLine();
        }
    }

    public class Animal
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    public class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Haf-Haf");
        }
    }

    public class Cat : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Meow-Meow");
        }
    }

    public class Caw : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Muuu-Muuu");
        }
    }
}
