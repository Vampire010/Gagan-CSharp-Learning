using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gagan_Selenium_Learning.WebDriverCommandsEx
{
    public class SnapDeal
    {
        IWebDriver _driver;
        [SetUp]
        public void openBrowser()
        {
            // launch Empty Chrome Browser
            _driver = new ChromeDriver();

            //naviagte to Url
            _driver.Navigate().GoToUrl("https://www.snapdeal.com/");
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            Thread.Sleep(5000);

            string parentWindow = _driver.CurrentWindowHandle;
            Console.WriteLine("parentWindow: " + parentWindow);

            IWebElement clickOnProduct = _driver.FindElement(By.XPath("//a[@href=\"https://www.snapdeal.com/product/bhawna-collection-loard-shiv-trishul/672311651336\"]"));

            clickOnProduct.Click();
            Thread.Sleep(5000);

            

            _driver.SwitchTo().Window(parentWindow);

            Thread.Sleep(5000);
            foreach (string windw in _driver.WindowHandles)
            {
                if (parentWindow != windw)
                {
                    _driver.SwitchTo().Window(windw);
                    break;
                }

                Console.WriteLine("windwID: " + windw);

            }
            Thread.Sleep(5000);
            _driver.SwitchTo().Window(parentWindow);

            Thread.Sleep(5000);

        }
        [TearDown]
        public void TearDown()
        {
            _driver.Close();
        }
    }
}
