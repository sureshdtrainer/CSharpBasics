using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.OOPS.constructors
{
    internal class Students
    {

        /*
         * Constructors have same name as of the className and dont have a return type
         * not even void
         * is a special method that is automatically called when an instance of a class
         * is created. The primary purpose of a contructor is to initialize the newly
         * created object. 
         * 
         * Types of Constructor:
         * 1. Default constructor
         * 2. no-arg cons
         * 3. parameterized constructor
         * 
         * 
         */

        string studentName;
        int studentRollNo;
        
        public Students()
        {
            Console.WriteLine("Calling Constructor");
            

        }


        public Students(int i)
        {
            Console.WriteLine(i);


        }

        public Students(string studentName, int studentRollNo) : this(10) //Constructor chaining
        {

            
            this.studentName = studentName;
            this.studentRollNo = studentRollNo;


        }

        static void Main(string[] args)
        {
            Students s = new Students("Rahul",1);
            Console.WriteLine(s.studentName);
            Console.WriteLine(s.studentRollNo);



            Students s1 = new Students("Cory",2);
            Console.WriteLine(s1.studentName);
            Console.WriteLine(s1.studentRollNo);


           // Students s2 = new Students();
        }



    }
}
