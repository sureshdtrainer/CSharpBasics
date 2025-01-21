using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.OOPS.polymorphism
{
    internal class RBI
    {


        /*
         * Can we achieve overloading by keeping the method signature same
         * and changing the return type?
         * 
         * Ans: NO
         * 
         * 
         */
        /*
        public void GetHomeLoanROI(string bankName, int amount)
        {


        }


        public void GetHomeLoanROI(int amount, string bankName)
        {


        }*/


        public double GetHomeLoanROI()
        {
            return 8.5;

        }


        public virtual RBI GetObj()
        {

            RBI rBI = new RBI();
            return rBI;
        }



        public virtual double GetCarLoanROI()
        {

            return 10.5;
        }

       /*

        public void Add(int a, double b)
        {


        }


        public void Add(double a, int b)
        {


        }




        public void Add(int a, int b, int c)
        {


        }*/

        public void DoLogin(int mobileName, string password)
        {


        }

        public void DoLogin(string username,  string password)
        {


        }


        static void Main(string[] args)
        {
            RBI obj = new RBI();
          //  obj.Add(1, 2);
            
            
        }


    }
}
