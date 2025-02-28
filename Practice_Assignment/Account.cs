using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Assignment
{
    class Account
    {
        public virtual void CalculateInterest()
        {
            Console.WriteLine("Calculating interest in Account...");
        }
    }

    class SavingsAccount : Account
    {
        public sealed override void CalculateInterest()
        {
            Console.WriteLine("Calculating interest for Savings Account...");
        }
    }
    // class SpecialSavingsAccount : SavingsAccount
    // {
    //     public override void CalculateInterest()  //ERROR: Cannot override sealed method
    //     {
    //         Console.WriteLine("Calculating interest for Special Savings Account...");
    //     }
    // }

    //class Program6
    //{
    //    static void Main()
    //    {
    //        Account acc = new Account();
    //        acc.CalculateInterest();

    //        SavingsAccount savings = new SavingsAccount();
    //        savings.CalculateInterest();
    //    }
    //}
}
