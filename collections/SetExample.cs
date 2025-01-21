using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.collections
{
    internal class SetExample
    {


        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            
            set.Add(10);
            set.Add(11);
            set.Add(12);
            set.Add(13);


            Console.WriteLine(set.Count);

          //  Console.WriteLine(set[1]);


            foreach (int i in set)
            {

                Console.WriteLine(i);
            }


        }
    }
}
