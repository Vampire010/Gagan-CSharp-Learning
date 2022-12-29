using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gagan_Selenium_Learning.LaunchBrowsers
{
    public class ChromeBrowserLaunch
    {
        IWebDriver _driver;
        [SetUp]
        public void openBrowser()
        {
            // launch Empty Chrome Browser
            //_driver = new ChromeDriver();

            //_driver = new FirefoxDriver();
            _driver = new EdgeDriver();
            //naviagte to Url
            _driver.Navigate().GoToUrl("https://parabank.parasoft.com/");
        }

        [Test]
        public void performAction()
        { 
            Assert.Pass();
        }

        [TearDown]
        public void closseBrowser()
        { 
            _driver.Quit();
        }

    }
}
