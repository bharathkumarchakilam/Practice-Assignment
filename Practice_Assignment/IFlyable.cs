using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Assignment
{
    interface IFlyable
    {
        void Fly();
    }

    interface ISwimmable
    {
        void Swim();
    }

    class Duck : IFlyable, ISwimmable
    {
        public void Fly()
        {
            Console.WriteLine("Duck is flying...");
        }

        public void Swim()
        {
            Console.WriteLine("Duck is swimming...");
        }
    }

    //class Program7
    //{
    //    static void Main()
    //    {
    //        Duck duck = new Duck();
    //        duck.Fly();
    //        duck.Swim();
    //    }
    //}
}
