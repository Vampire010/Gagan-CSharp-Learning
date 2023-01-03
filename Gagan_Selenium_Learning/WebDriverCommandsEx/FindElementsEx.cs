using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gagan_Selenium_Learning.WebDriverCommandsEx
{
    public class FindElementsEx
    {
        IWebDriver _driver;
        [SetUp]
        public void openBrowser()
        {
            // launch Empty Chrome Browser
            _driver = new ChromeDriver();

            //naviagte to Url
            _driver.Navigate().GoToUrl("https://parabank.parasoft.com/");
            _driver.Manage().Window.Maximize();
        }


        [Test]
        public void Test1()
        {
            var links = _driver.FindElements(By.TagName("a"));

            foreach(var All_Liinks in links)
            { 
                string lnks = All_Liinks.GetAttribute("href");
                Console.WriteLine(lnks);
            
            }
            Console.WriteLine("********************************************888");

            var text = _driver.FindElements(By.TagName("p"));

            foreach (var pagetxt in text)
            {
                string txt = pagetxt.Text;
                Console.WriteLine(txt);

            }


        }
        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("Close the Browser");
            _driver.Close();
        }
    }
}
