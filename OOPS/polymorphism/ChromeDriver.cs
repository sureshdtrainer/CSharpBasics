using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.OOPS.polymorphism
{
    internal class ChromeDriver : RemoteWebDriver
    {

        public override void CaptureScreenshot()
        {
            Console.WriteLine("Capturing screenshot in Chrome");
        }

        public override void Click()
        {

            Console.WriteLine("Clicking in Chrome");
        }



        public override void SendKeys()
        {
            Console.WriteLine("Typing in Chrome");
        }



    }
}
