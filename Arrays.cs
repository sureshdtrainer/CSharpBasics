using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Arrays
    {

        /*
         * Arrays are the collection of similar dataypes
         * Each variable in an array is known as array element
         * Each variable of array is referenced by a particular integer number
         * which is also known as array index
         * The total number of variables in array decide the length of an array
         * The very first index of an array always starts from 0
         * 
         * 1D, 2D, 3D
         * 
         * arrays --> Objects --->  String []
         * 
         * 
         */

        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            string[] names = new string[10];

            Console.WriteLine(names.Length);

            /*
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[9] = 10;

            Console.WriteLine(numbers[2]);
            */

            Random random = new Random();

            for(int i = 0; i < numbers.Length; i++)
            {

                numbers[i] = random.Next(1,101);
                //Console.WriteLine(numbers[i]);

            }

            foreach(int number in numbers)
            {
                Console.WriteLine(number);

            }

            Console.WriteLine("---Printing reverse values from an array");


            for(int i = numbers.Length-1; i>= 0; i--)
            {

                Console.WriteLine(numbers[i]);
            }

            int[] arrays1 = new int[7] {1,2,3,4,5,6,7};

            Console.WriteLine(arrays1.Length);
            Console.WriteLine(arrays1[4]);

        }
    }
}