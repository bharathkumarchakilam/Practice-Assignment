// See https://aka.ms/new-console-template for more information
using System;
using Practice_Assignment;

class Prpgram
{
    static void Main()
    {
        Console.WriteLine("\n*****First Question *****");
        Car car = new Car { Brand = "Toyota", Speed = 180 };
        Bike bike = new Bike { Brand = "Yamaha", Speed = 120 };

        car.DisplayInfo();
        bike.DisplayInfo();

        Console.WriteLine("\n*****second Question *****");
        Car1 car1 = new Car1("Toyota", 180, 4);
        Bike1 bike1 = new Bike1("Yamaha", 120, true);

        car1.DisplayInfo();
        bike1.DisplayInfo();

        Console.WriteLine("\n*****thrid Question *****");
        Employee emp = new Employee("Alice", 50000);
        Manager mgr = new Manager("Bob", 80000, 15000);

        emp.DisplayInfo();
        Console.WriteLine();
        mgr.DisplayInfo();

        Console.WriteLine("\n*****fourth Question *****");
        Animal dog = new Dog();
        Animal cat = new Cat();

        dog.MakeSound();
        cat.MakeSound();

        Console.WriteLine("\n*****Fifth Question *****");
        Robot robot = new Robot();
        robot.Start();  // Inherited from Machine
        robot.Move();   // Implemented from IMovable

        Console.WriteLine("\n***** sixth Question *****");
        Account acc = new Account();
        acc.CalculateInterest();

        SavingsAccount savings = new SavingsAccount();
        savings.CalculateInterest();

        Console.WriteLine("\n*****Seventh Question *****");
        Duck duck = new Duck();
        duck.Fly();
        duck.Swim();

        Console.WriteLine("\n*****Eighth Question *****");
        // Creating a Student object
        Student student = new Student { Name = "Alice", StudentID = 101 };

        // Upcasting: Converting Student to Person (Implicit Casting)
        Person person = student;
        person.ShowInfo();

        // Downcasting: Converting Person back to Student (Explicit Casting)
        if (person is Student)
        {
            Student downcastedStudent = (Student)person;
            downcastedStudent.ShowStudentInfo();
        }
        else
        {
            Console.WriteLine("Downcasting failed.");
        }
        Console.WriteLine("\n*****nineth Question *****");
        Product laptop = new ElectronicProduct("Laptop", 1000);
        Product tshirt = new ClothingProduct("T-Shirt", 50);

        Console.WriteLine($"Laptop Discounted Price: ${laptop.GetDiscountedPrice()}");
        Console.WriteLine($"T-Shirt Discounted Price: ${tshirt.GetDiscountedPrice()}");

        Console.WriteLine("\n*****tenth Question *****");
        SecuritySystem security = new SecuritySystem();
        security.AuthenticateUser();

    }
}