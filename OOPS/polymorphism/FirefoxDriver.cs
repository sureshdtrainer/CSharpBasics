using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.OOPS.polymorphism
{
    internal class FirefoxDriver : RemoteWebDriver
    {
        public override void CaptureScreenshot()
        {
            Console.WriteLine("Capturing screenshot in Firefox");
        }

        public override void Click()
        {

            Console.WriteLine("Clicking in Firefox");
        }


        public void CaptureNetworkRequest()
        {


        }


        public override void SendKeys()
        {
            Console.WriteLine("Typing in Firefox");
        }


        static void Main(string[] args)
        {

            RemoteWebDriver driver = new FirefoxDriver();
            driver.GetTitle();
           // driver.CaptureNetworkRequest();


        }

    }
}
