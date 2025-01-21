using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class BasicConcepts
    {

        /*
         * string is a class //as a keyword and String as a class
         * string concatenation
         * operators
         * if-else
         * loops etc
         * 
         * 
         */

        static void Main(string[] args)
        {

            /*
                        string s = "Hello";
                        Console.WriteLine(s);
                        String s1 = "Hi";
                        Console.WriteLine(s1);

                        String s2 = new String("How are you?");
                        Console.WriteLine(s2);
            */


            string s1 = "Hello";
            string s2 = "2";
            string s3 = "World";


            Console.WriteLine(s1+s2+s3);

            Console.WriteLine(10 + 20 + s2 + s3); 

            Console.WriteLine(s1+(10+20)+s2+s3);  

            //BODMAS

            // + operator --> Binary Operator ---> it requires 2 operands to perfom the operations

            // 10 + 23

            //+ operator --> addition / concatenation
            // concatenation ---> if any of the operand provided to "+" operator is a string
            // then "+" operator will always do concatenation



        }
    }
}