using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.OOPS.inheritance
{
    internal class Audi : Car
    {

        static void Main(String[] args)
        {
            
            Audi car = new Audi();
            car.Start();
        }
    }
}
