using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Assignment
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual double GetDiscountedPrice()
        {
            return Price; // No discount by default
        }
    }

    class ElectronicProduct : Product
    {
        public ElectronicProduct(string name, double price) : base(name, price) { }

        public override double GetDiscountedPrice()
        {
            return Price * 0.90; // 10% discount
        }
    }

    class ClothingProduct : Product
    {
        public ClothingProduct(string name, double price) : base(name, price) { }

        public override double GetDiscountedPrice()
        {
            return Price * 0.80; // 20% discount
        }
    }

    //class Program
    //{
    //    static void Main()
    //    {
    //        Product laptop = new ElectronicProduct("Laptop", 1000);
    //        Product tshirt = new ClothingProduct("T-Shirt", 50);

    //        Console.WriteLine($"Laptop Discounted Price: ${laptop.GetDiscountedPrice()}");
    //        Console.WriteLine($"T-Shirt Discounted Price: ${tshirt.GetDiscountedPrice()}");
    //    }
    //}
}
