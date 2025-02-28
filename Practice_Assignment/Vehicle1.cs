using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Assignment
{
    using System;

    class Vehicle1
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public Vehicle1(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
        }
    }

    class Car1 : Vehicle1
    {
        public int NumberOfDoors { get; set; }

        public Car1(string brand, int speed, int doors) : base(brand, speed)
        {
            NumberOfDoors = doors;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Car has {NumberOfDoors} doors.");
        }
    }

    class Bike1 : Vehicle1
    {
        public bool HasGear { get; set; }

        public Bike1(string brand, int speed, bool hasGear) : base(brand, speed)
        {
            HasGear = hasGear;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Bike has gear: {HasGear}");
        }
    }

    //class Program2
    //{
    //    static void Main()
    //    {
    //        Car1 car1 = new Car1("Toyota", 180, 4);
    //        Bike1 bike1 = new Bike1("Yamaha", 120, true);

    //        car1.DisplayInfo();
    //        bike1.DisplayInfo();
    //    }
    //}

}
