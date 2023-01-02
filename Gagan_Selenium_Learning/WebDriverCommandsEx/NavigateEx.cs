using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gagan_Selenium_Learning.WebDriverCommandsEx
{
    public class NavigateEx
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
        public void performAction()
        {

            _driver.FindElement(By.XPath("//*[@id=\"loginPanel\"]/p[2]/a")).Click();
            Thread.Sleep(3000);

            _driver.Navigate().Back();
            Thread.Sleep(3000);
            _driver.Navigate().Forward();
            Thread.Sleep(3000);
            _driver.Navigate().Refresh(); ;

            Thread.Sleep(8000);

        }

        [TearDown]
        public void closseBrowser()
        {
           _driver.Quit();

        }
    }
}
