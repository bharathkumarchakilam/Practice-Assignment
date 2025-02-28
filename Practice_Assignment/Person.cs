using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Assignment
{
    class Person
    {
        public string Name { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Person: {Name}");
        }
    }

    class Student : Person
    {
        public int StudentID { get; set; }

        public void ShowStudentInfo()
        {
            Console.WriteLine($"Student: {Name}, ID: {StudentID}");
        }
    }

    //class Program
    //{
    //    static void Main()
    //    {
    //        // Creating a Student object
    //        Student student = new Student { Name = "Alice", StudentID = 101 };

    //        // Upcasting: Converting Student to Person (Implicit Casting)
    //        Person person = student;
    //        person.ShowInfo();

    //        // Downcasting: Converting Person back to Student (Explicit Casting)
    //        if (person is Student)
    //        {
    //            Student downcastedStudent = (Student)person;
    //            downcastedStudent.ShowStudentInfo();
    //        }
    //        else
    //        {
    //            Console.WriteLine("Downcasting failed.");
    //        }
    //    }
    //}
}
