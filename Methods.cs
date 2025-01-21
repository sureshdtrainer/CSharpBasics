using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Methods
    {

        /*
         * Methods are block of statements which are used to do a specific task
         * Methods are generally used to divide a large code into manageable
         * chunks of codes.
         * 
         * Syntax:
         * <access-modifier/specifier> <return-type> functionName(<parameters>){
         * 
         *  //method / function body
         *  <return statement>
         * }
         * 
         * Optional: <access-modifier/specifier>, <parameters>,  <return statement>
         * Mandatory:<return-type> functionName (),{}
         */


        public int Add(int num1, int num2)
        {
           

            int sum = num1 + num2;
            return sum;
            //Console.WriteLine(sum);

        }

        static void Main(string[] args)
        {


            Methods methods = new Methods();
           int numbers =  methods.Add(10,20);
            Console.WriteLine(numbers);
            Console.WriteLine(methods.Add(100,200));
            Console.WriteLine(methods.Add(20,40));
            Console.WriteLine(methods.Add(30,50));
            Console.WriteLine(methods.Add(100,100));




        }
    }
}