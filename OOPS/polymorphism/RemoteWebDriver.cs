using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.OOPS.polymorphism
{
    internal abstract class RemoteWebDriver
    {
        public RemoteWebDriver() { }

        public virtual void Click()
        {
            Console.WriteLine("Clicking on some element");
        }

        public abstract void CaptureScreenshot();

        public virtual void SendKeys()
        {

            Console.WriteLine("Typing in an Element");
        }

        public void GetTitle()
        {

            Console.WriteLine("Getting the title");
        }

    }
}
