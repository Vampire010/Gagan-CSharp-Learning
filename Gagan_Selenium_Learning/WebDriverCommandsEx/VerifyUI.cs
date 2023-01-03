using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gagan_Selenium_Learning.WebDriverCommandsEx
{
    public class VerifyUI
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
            IWebElement readMoreUi = _driver.FindElement(By.XPath("//*[@id=\"rightPanel\"]/p[2]/a"));

            string fontSize = readMoreUi.GetCssValue("font-size");
            Console.WriteLine(fontSize);

            string fontstyle = readMoreUi.GetCssValue("font-style");
            Console.WriteLine(fontstyle);
            string fontfamily = readMoreUi.GetCssValue("font-family");
            Console.WriteLine(fontfamily);
            string fontcolor = readMoreUi.GetCssValue("color");
            Console.WriteLine(fontcolor);



        }
        [TearDown]
        public void TearDown()
        {
           // Console.WriteLine("Close the Browser");
            _driver.Close();
        }
    }
}
