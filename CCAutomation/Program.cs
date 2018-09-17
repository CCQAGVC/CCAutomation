using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;

namespace CCAutomation
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver Chrome = new ChromeDriver();
            Chrome.Navigate().GoToUrl("https://www.casinoclub.com");
            Console.ReadLine();   
        }
    }
}





