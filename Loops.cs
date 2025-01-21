using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Loops
    {

        static void Main(string[] args)
        {


            /*
             * LOOPS - the way of repeating lines of codes
             * until the loop condition is met
             * 
             * While loop
             * Do-While loop
             * For Loop
             * ForEach loop
             * 
             * While Loop - repeats a block of code until the condition is true
             * 
             */
            /*  int count = 1;
              while (count <= 10)
              {
                  Console.WriteLine(count);
                  count++;
              }
            */
            /*
            string userInput;

            
            do
            {
                Console.WriteLine("Enter 'Yes' or 'No' ");
                userInput = Console.ReadLine();

            }while (userInput !="Yes" && userInput !="No");


            Console.WriteLine("You entered : "+userInput);

            */

            /*
             * while --> when the number of iterations are unknown
             * for ---> number of iterations are known
             * do while --> at least for one time irrespective of the condition
             */

            /*
             for(int i=1;i<=10;i++)
             {

                 Console.WriteLine(i);

             }*/


            /*
             * Nesting of Loops 
             * 
             * The placing of one loop inside the body of another loop 
             * is known as nesting of loops
             * 
             * While working with nesting loops the outer loop will change
             * only when inner loop is completely finshed
             * 
             * While ---> 3
             * for ---> 4
             * do-while --> 5
             * 
             * 
             */

            int i = 0;
            

            while(i<3)
            {

                for(int j = 0; j < 4; j++) {

                    int k = 0;
                    do
                    {
                        Console.WriteLine("i---->"+i+" j---->"+j+" k---->"+k);
                        k++;
                    } while (k < 5);
                
                
                }
                i++;
            }

            /*
             * 0,0,0
             * 0,0,1
             * 0,0,2
             * 0,0,3
             * 0,0,4
             * 0,1,0
             * 0,1,1
             * 0,1,2
             */




        }
    }
}