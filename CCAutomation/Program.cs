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
            NEmail.gurilamailAPI.GetNewEmaillAdress();
            NEmail.gurilamailAPI.getbetween(NEmail.gurilamailAPI.GetBody().ToString() , NEmail.gurilamailAPI.ProdActivationstr, NEmail.gurilamailAPI.ProdActivationend);
            Console.ReadLine(); 
        }
    }
}

