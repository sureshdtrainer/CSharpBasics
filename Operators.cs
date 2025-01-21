using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Operators
    {


        static void Main(string[] args)
        {


            //Operators ---> arithmetic, relation, conditional, unary

            //Arithmetic operators ---> binary operators
            //+,-,*,/,%(mod)

            int i = 20;
            int j = 20;

         //   Console.WriteLine(i%j);  //(int)0.5 //int/double

            bool b = true;
            bool c = false;

            //   Console.WriteLine(b+c);

            /*
             * Comparison Operator | Equality | Relational operator
             *  == Equal to
             * != Not Equal to
             * > Greater than
             * < Less than
             * >= Greater than or Equal to
             * <= less than or Equal to
             * These operators compare two values and return a Boolean true or false
             * 
             */


            int num1 = 50;
            int num2 = 5;

            //Console.WriteLine(num1 >= num2);

            /*
             * Logical / Conditional operators
             * 
             * && (Logical AND)
             * || (Logical OR)
             * ! (Logical Not)
             * 
             */

            bool hasHighTemp = false;
            bool hasSoreThroat = false;

            if(hasHighTemp && hasSoreThroat)
            {
                //Console.WriteLine("You must have a flu. Please see a doctor.");
            }


           // Console.WriteLine(hasHighTemp && hasSoreThroat);

          //  Console.WriteLine(hasHighTemp || hasSoreThroat);



            bool isWeekend = false;

            if (!isWeekend)
            {

             //   Console.WriteLine("It's a weekday, Time to go to work");
            }

            /*
             * Assignment Operators
             * = simple assignment
             * += Add and Assign
             * -= Subtract and Assign
             * *= Mult and Assign
             * /= Div and Assign
             * %= modulus and Assign
             * 
             */


            int a = 10;
            a %= 2;
            // Console.WriteLine(a); // a = a-2


            /*
             *  Increment and Decrement operators
             *  Prefix and Postfix ++ , --
             * 
             * 
             */


            //Prefix increment (++var)

            // int x = 5;
            // int y = ++x; //First x is incremented to 6 then y is assigned the value of x, so y is 6

            // Console.WriteLine(y);


            //Post increment (var++)


            //  int x = 5;
            //    int y = x++; //First Y is assigned the value of X which is 5 and then X is incremented to 6
            //   Console.WriteLine(y);
            //  Console.WriteLine(x);


            // Prefix Decrement (--var)

            // int x = 5;
            // int y = --x; //First X is decremented to 4, then Y is assigned the value of X and Y is 4

            // Console.WriteLine(y);


            // POST Decrement (var--)


            int x = 5;
            int y = x--; //First Y is assigned the value of X which is 5 and then X is decrement to 4
            Console.WriteLine(y);
            Console.WriteLine(x);



            /*
             * Naming Conventions
             * 
             * 
             * Camel Case : used to local variables and method parameters.
             * Pascal Case: used for public members like Class names, method names
             * constants and properties
             * Underscore Prefix (_fieldName): Commonly used with private fields
             * Interface names: Typically starts with an "I" followed by PascalCase
             * IWebDriver
             * 
             * 
             */


            //thedarknight

            int theDarkNight;

            //TheDarkNight








        }
    }
}