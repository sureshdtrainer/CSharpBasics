using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.exceptions
{
    internal class ExceptionHandling
    {

        /*
         * try - A block of code where exceptions can occur
         * .
         * catch - A block of code to handle the exception
         * finally - A block of code that will always execute, regardless of whether an
         * exception was thrown or not.
         * throw - A statement to explicitly throw an exception.
         * 
         * 
         * 
         */

        static void ValidateNumber(int number)
        {

            if (number < 0)
            {
                throw new ArgumentException("Number must be non-negative");
            }
        }


        static void Main(string[] args)
        {

            try
            {
                ValidateNumber(-1);
            }catch (ArgumentException e)
            {
                Console.WriteLine("Validation error : "+e.Message);

            }


            /*
            try
            {
                int[] numbers = { 1, 2, 3, 4, 5 };
                Console.WriteLine(numbers[6]);
                Console.WriteLine("Hello");

            }
            catch (Exception e)
           {
                Console.WriteLine("An error occurred" + e.Message);


            }*/
            /*

            try
            {


                int a = 10;
                int b = 0;
                int result = a / b;
            }catch (Exception e)
            {
                Console.WriteLine("An Error Occurred : "+e.Message);

            }finally
            {

                Console.WriteLine("This will always be executed.");
            }


            */



        }

    }
}
