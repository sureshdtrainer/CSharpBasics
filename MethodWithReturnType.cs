using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class MethodWithReturnType
    {


        /*
         * 
         *  ATM Machine --> 
         * 
         * PIN Validation
         * Withdraw Cash
         * 
         * public bool PinVerification(int pin){
         * 
         *  if(true)
         *      return true
         *  else
         *      return false
         * }
         * public void Withdraw(int amount, int pin){
         * 
         * PiVerification(234234)
         * Withdraw Cash
         * 
         * SOLID Principle
         * 
         * PrintEvenorOdd
         * CheckEvenOrOdd - True / False
         * 
         * 
         * 
         * }
         */


        public void PrintEvenOrOdd(int number)
        {

           bool result = CheckEvenOrOdd(number);

            if (result)  //true
            {

                Console.WriteLine("Number : "+number+" is Even");
            }else
            {

                Console.WriteLine("Number : " + number + " is Odd");
            }



        }
        
        public bool CheckEvenOrOdd(int number)
        {
            if(number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }






    }
}