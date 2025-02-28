using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Assignment
{
    sealed class SecuritySystem
    {
        public void AuthenticateUser()
        {
            Console.WriteLine("User authenticated successfully.");
        }
    }

    // This will cause a compilation error because SecuritySystem is sealed
    // class AdvancedSecurity : SecuritySystem 
    // {
    // }

    //class Program
    //{
    //    static void Main()
    //    {
    //        SecuritySystem security = new SecuritySystem();
    //        security.AuthenticateUser();
    //    }
    //}
}
