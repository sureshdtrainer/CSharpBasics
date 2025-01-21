using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.testcases
{
    public class Car
    {


        //Access Modifiers
        public string brand = "BMW";
        private int price = 100000;
        protected string country = "India";
        internal bool electric = true;
        string color = "red";


        void DefaultMethod()
        {

            Console.WriteLine("Default Method");
        }

        public void PublicMethod()
        {

            Console.WriteLine("Public Method");
        }


        private void PrivateMethod()
        {
            Console.WriteLine("Private Method");
        }


        protected void ProtectedMethod()
        {

            Console.WriteLine("Protected Method");
        }


        internal void InternalMethod()
        {
            Console.WriteLine("Internal Method");
        }



        static void Main(string[] args)
        {

            Car car = new Car();
            Console.WriteLine(car.price);
            Console.WriteLine(car.country);
            Console.WriteLine(car.color);
            Console.WriteLine(car.brand);
            Console.WriteLine(car.electric);
            car.PublicMethod();
            car.PrivateMethod();
            car.ProtectedMethod();
            car.InternalMethod();
            car.DefaultMethod();





        }



    }
}
