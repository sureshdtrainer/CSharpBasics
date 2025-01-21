using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.collections
{
    internal class Dictionary
    {
        

        static void Main(string[] args)
        {
            Dictionary<int, string> student = new Dictionary<int, string>();
            student.Add(101, "Rahul");
            student.Add(102, "Cory");
            student.Add(103, "Amit");
            student.Add(104, "Jack");


            Console.WriteLine(student[101]);

            Console.WriteLine(student.ContainsKey(102));


            foreach (KeyValuePair<int, string> kvp in student)
            {

                Console.WriteLine(kvp.Key+"   "+kvp.Value);

            }







        }
    }
}
