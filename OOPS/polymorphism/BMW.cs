using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.OOPS.polymorphism
{
    internal class BMW : IVehicle, IEngine
    {
        public void Gear()
        {
            
        }

        public void BMWHorns()
        {

        }


        static void Main(string[] args)
        {

            IVehicle bMW = new BMW();
            bMW.Gear();
           // bMW.BMWHorns();

        }

    }
}
