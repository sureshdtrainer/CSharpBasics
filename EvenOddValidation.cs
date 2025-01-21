using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class EvenOddValidation
    {

       static void Main(string[] args)
        {

            MethodWithReturnType m = new MethodWithReturnType();
            Console.WriteLine("Please enter a number to check Even or Odd: ");
            int num = Convert.ToInt32(Console.ReadLine());
            m.PrintEvenOrOdd(num);


        }
    }
}
