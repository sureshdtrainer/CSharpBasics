using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class TwoDArray
    {

        static void Main(string[] args)
        {
            /*
             * 2 D Array which is also called as Multidimensional array
             * 
             * 
             * 
             */


            int[,] myArray = new int[2, 3];

            myArray[0, 0] = 10;
            myArray[0, 1] = 11;
            myArray[0, 2] = 12;

            myArray[1, 0] = 13;
            myArray[1, 1] = 14;
            myArray[1, 2] = 15;

            Console.WriteLine(myArray[1, 1]);

            Console.WriteLine(myArray.GetLength(0));


            for(int i = 0; i < myArray.GetLength(0); i++)
            {
                for(int j = 0; j < myArray.GetLength(1); j++)
                {

                    Console.Write(myArray[i, j] + " ");
                }

                Console.WriteLine();

            }




        }
    }
}