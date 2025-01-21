using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class CallByValueOrRef
    {

        public static void CallByValue(int num)
        {

            num = 10;
            Console.WriteLine(num);

        }



        public static void CallByRef(ref int num)
        {


            num = 10;
            Console.WriteLine(num);
        }





        static void Main(string[] args)
        {
            int num = 5;
            Console.WriteLine("Before Call by Ref : "+num);
           // CallByValue(num);
           CallByRef(ref num);
            Console.WriteLine("After Call by Ref : " + num);

        }
    }
}
