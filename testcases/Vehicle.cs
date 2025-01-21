using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.testcases
{
    internal class Vehicle : Car
    {


        static void Main(string[] args)
        {

            Vehicle car = new Vehicle();
           // Console.WriteLine(car.price); //Private access modifiers cannot be accessed outside the class
            Console.WriteLine(car.country);
           // Console.WriteLine(car.color);
            Console.WriteLine(car.brand);
            Console.WriteLine(car.electric);
            car.PublicMethod();
           // car.PrivateMethod();
            car.ProtectedMethod();
            car.InternalMethod();
          //  car.DefaultMethod();





        }
    }
}
