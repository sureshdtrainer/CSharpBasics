using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.OOPS.inheritance
{
    internal class AudiEV : Audi
    {


        static void Main(string[] args)
        {
            AudiEV car = new AudiEV();
            car.Start();


        }
    }
}
