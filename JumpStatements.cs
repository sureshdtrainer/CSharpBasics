using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class JumpStatements
    {

        /*
         * Break, Continue, return, goto
         * 
         */

        static void Main(string[] args)
        {

           for(int i = 0;i<10;i++)
            {

                if(i>=5 && i<=7)
                {
                    //break; //exit the loop when i is 5
                    continue; //in continue it will skip that iteration
                }

                Console.WriteLine(i);
            }


        }
    }
}
