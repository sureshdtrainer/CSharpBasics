using OpenQA.Selenium.DevTools.V122.Emulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class VariableTypesAndScope
    {
        /*
         *  1. Local Variable
         *     Scope: Local variables are declared within methods, constructors, or blocks {}. They are only
         *     accessible withing the method or block they are declared in.
         *  2. Instance Variable / Non-static variable
         *     Scope: Instance variables are declared inside a class but outside any method. They are accessible
         *     by any non-static methods in the class. Each instance of the class has its own copy of instance variables.
         *  3. Static variables / class variables
         *     Scope: Static variables are declared with the 'static' keyword inside a class. They are shared among all instances of the class. Only
         *     one copy of the static variable exists, regardless of how many instances of the class are created.
         *  4. Constant variables
         *     Scope: Constants are immutable values which are known as compile-time and do not change for the life of the program. They are declared with the 'const' keyword
         *     Constant variable once declared can't be changed or updated. The value cannot be left empty it has to be initiliased during variable declaration only
         *  5. Readonly variables
         *     Scope: Readonly variables are similar to const, once defined cannot be updated or changed
         *     Unlike const variables, readonly variables can be left empty, Readonly variable values can only be updated via constructor
         *  6. Parameter variables
         *     Scope: Parameter variables are declared in method signatures and are use to pass values to methods.
         *     They are accessible only within the method they are declared in.
         */

        int i = 10; //instance variable
        int x = 200;
        static int j = 20; //static variable

        readonly int a=200;


        public VariableTypesAndScope(int i)
        {

            a = i * 10;

        }


        public void Add(int num1, int num2)
        {

            int sum = num1 + num2;
            Console.WriteLine(sum);
        }





        public void DoSomething()
        {
            Console.WriteLine(x);
          int i = 10; //local variable

            if(i == 10)
            {
                int j = 20;

            }
            Console.WriteLine(j);
        }


       
       


        static void Main(string[] args)
        {

          //  const double PI;
         //   PI = 123;

            int xyz = 100;

            xyz = 200;

            VariableTypesAndScope obj = new VariableTypesAndScope(10);
            Console.WriteLine(obj.i);
            obj.Add(10, 20);
            
            Console.WriteLine("Read only variable value 1 : "+obj.a);

            

         //   obj.a = 300;

            VariableTypesAndScope obj2 = new VariableTypesAndScope(20);
            Console.WriteLine("Read only variable value 2 : " + obj2.a);

            obj2.i = 100;
            Console.WriteLine(obj.i);
            Console.WriteLine(obj2.i);

            Books b = new Books();
            Books.numberOfBooks = 10;
            Books.displayNumbersOfBooks();


        }
    }
}