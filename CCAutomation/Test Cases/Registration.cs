using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;


namespace CCAutomation.Test_Cases
{

    [TestFixture]
    class Registration
    {
     
    [Test]
        public void tripo() 
	{
        IWebDriver Chrome = new ChromeDriver();
        Chrome.Navigate().GoToUrl("https://www.casinoclub.com");
        Assert.IsTrue(Chrome.Title.Equals("Casinoclub"));   


	}


    }
}
