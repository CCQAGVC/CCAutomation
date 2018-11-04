using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;


namespace CCAutomation.Functions
{
    class Driversconfig
    {

        public static void Chdriver()
        {

            IWebDriver Chromed = new ChromeDriver();


        }


        public static void Edgedriver()
        {

            IWebDriver Edged = new EdgeDriver();

        }


        public static void FFdriver()
        {

            IWebDriver FireFoxd = new FirefoxDriver();

        }

    }
}
