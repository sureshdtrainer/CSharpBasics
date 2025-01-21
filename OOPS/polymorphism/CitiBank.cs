using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.OOPS.polymorphism
{
    internal class CitiBank : RBI
    {
        public override double GetCarLoanROI()
        {

            return 12.5;
        }


        public override CitiBank GetObj()
        {

            CitiBank citi = new CitiBank();
            return citi;
        }

        static void Main(string[] args)
        {
            
            CitiBank citiBank = new CitiBank();
            citiBank.GetCarLoanROI();

        }

    }
}
