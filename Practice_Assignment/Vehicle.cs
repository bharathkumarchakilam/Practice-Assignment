using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Assignment
{
    class Vehicle
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
        }
    }

    class Car : Vehicle { }
    class Bike : Vehicle { }

    //class Program1
    //{
    //    static void Main()
    //    {
    //        Car car = new Car { Brand = "Toyota", Speed = 180 };
    //        Bike bike = new Bike { Brand = "Yamaha", Speed = 120 };

    //        car.DisplayInfo();
    //        bike.DisplayInfo();
    //    }
    //}
}
