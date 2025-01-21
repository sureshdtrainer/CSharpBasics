using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.collections
{
    internal class Collections
    {

        /*
         * System.Collections (deprecated) - List, HastSet, Dict, 
         * System.Collections.Generic namespaces
         * 
         * 
         * Generic vs Non-Generic?
         * 
         * Generic --> The classes where we can store only one type of value, In these classes
         * while creating the object we define the type of the object which is going to be stored
         * with the help of angular brackets <>
         * 
         * Non-Generic --> These classes where you can store any type of value --> never use this.
         * 
         * 
         * 
         */


        static void Main(string[] args)
        {
            
            List<string> list = new List<string>();
            list.Add("Apple"); //0
            list.Add("Mango"); //1
            list.Add("Banana"); //2
            list.Add("Orange"); //3
            list.Add("Mango"); //4


            Console.WriteLine("Total size of the list is --> "+list.Count);

           // Console.WriteLine(list[1]);

            /*
            for(int i = 0; i < list.Count; i++)
            {

                Console.WriteLine(list[i]);
            }*/


            foreach (var item in list) {

                Console.WriteLine(item);
            }





        }


    }
}
