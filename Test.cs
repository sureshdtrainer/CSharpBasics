using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Test
    {

        public void TestMethod()
        {

            Console.WriteLine("Inside Test Method");
        }


        static void Main(string[] args)
        {

            Test t = new Test();
            t.TestMethod();



        }




        }
    }
