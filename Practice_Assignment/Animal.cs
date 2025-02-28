using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Assignment
{
    abstract class Animal
    {
        public abstract void MakeSound();
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog: Woof! Woof!");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat: Meow! Meow!");
        }
    }

    //class Program4
    //{
    //    static void Main()
    //    {
    //        Animal dog = new Dog();
    //        Animal cat = new Cat();

    //        dog.MakeSound();
    //        cat.MakeSound();
    //    }
    //}
}
