using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.OOPS.polymorphism
{
    internal class TestBrowser
    {

        /*
         * Q: Can we change the return type while performing Overriding
         * 
         * Ans: NO / YES - In case the return types are Covariant
         * 
         * 
         * Covariant - The return types are classNames and there is Parent-Child
         * relationship between those classes.
         * 
         * ChromeDriver driver = new ChromeDriver();
         * FirefoxDriver driver1 = new FirefoxDriver();
         * IWebDriver driver = new ChromeDriver(); //Polymorphic reference 
         * 
         */


        static void Main(string[] args)
        {
            
            RemoteWebDriver driver = new FirefoxDriver();
            RemoteWebDriver driver1 = new ChromeDriver();
           // ChromeDriver driver2 = new RemoteWebDriver();
            driver.Click();
            driver.SendKeys();

        }
    }
}
