using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.OOPS.inheritance
{
    internal class ChildClass : ParentClass
    {
        public void Display()
        {

            Console.WriteLine("Display from child");
            base.Display();
        }

        static void Main(string[] args)
        {

            ChildClass child = new ChildClass();
            child.Display();
          

        }


    }
}
