using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Assignment
{
    interface IMovable
    {
        void Move();
    }

    class Machine
    {
        public void Start()
        {
            Console.WriteLine("Machine is starting...");
        }
    }

    class Robot : Machine, IMovable
    {
        public void Move()
        {
            Console.WriteLine("Robot is moving...");
        }
    }

    //class Program
    //{
    //    static void Main()
    //    {
    //        Robot robot = new Robot();
    //        robot.Start();  // Inherited from Machine
    //        robot.Move();   // Implemented from IMovable
    //    }
    //}
}
