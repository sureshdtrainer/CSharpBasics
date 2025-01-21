using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class Car
    {

        string Color;
        string Brand;


        public void Accelerate()
        {
            Console.WriteLine("The car is accelerating..");

        }


        public void Break()
        {

            Console.WriteLine("The car is applying breaks");
        }




        static void Main(string[] args)
        {

            Car car = new Car();
            car.Break();
            car.Color = "Red";
            car.Brand = "BMW";
            car.Accelerate();

        }


    }
}
