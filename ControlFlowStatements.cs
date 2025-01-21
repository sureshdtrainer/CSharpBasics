using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class ControlFlowStatements
    {

        static void Main(string[] args)
        {

            /*if ifelse, switch case, loops - for, forEach, while DoWhile
             * 
             * If, If-Else, If-ElseIf-Else statements
             * 
             */

            Random random = new Random();
            int number = random.Next(5); //0 4
            Console.WriteLine(number);
            /*if (number > 10)
                Console.WriteLine(number + " is greater than 10");
            else
                Console.WriteLine(number + " is less than 10");
            */

            /*
            if (number == 0)
            {
                Console.WriteLine("Number is ZERO " + number);
            }else if (number == 1)
            {
                Console.WriteLine("Number is ONE "+ number);
            }
            else if (number == 2)
            {
                Console.WriteLine("Number is TWO " + number);
            }
            else
            {

                Console.WriteLine("Number is either THREE or FOUR " + number);
            }*/



            switch (number)
            {
                case 0:
                    Console.WriteLine("Number is ZERO " + number);
                    break;
                case 1:
                    Console.WriteLine("Number is ONE " + number);
                    break;
                case 2:
                    Console.WriteLine("Number is TWO " + number);
                    break;
                default:
                    Console.WriteLine("Number is Either Three or Four " + number);
                    break;
            }




        }
    }
}