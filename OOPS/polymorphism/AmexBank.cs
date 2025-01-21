using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.OOPS.polymorphism
{
    internal class AmexBank : RBI
    {

        public override double GetCarLoanROI()
        {

            return 11.5;
        }


        static void Main(string[] args)
        {
            AmexBank amexBank = new AmexBank();
            Console.WriteLine(amexBank.GetCarLoanROI());



        }


    }
}
