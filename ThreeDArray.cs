using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class ThreeDArray
    {

        static void Main(string[] args)
        {
            int[,,] myArray = new int[2, 3,4];

            Random random = new Random();


            for(int i = 0; i < myArray.GetLength(0); i++)
            {

                for(int j = 0; j < myArray.GetLength(1); j++)
                {

                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {

                        myArray[i, j, k] = random.Next(1, 101);
                        Console.Write(myArray[i, j, k]+ " ");


                    }
                    Console.WriteLine();

                }

                Console.WriteLine();


            }








        }
    }
}