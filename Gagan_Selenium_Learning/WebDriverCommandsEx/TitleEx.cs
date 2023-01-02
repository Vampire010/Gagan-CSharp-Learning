using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace Gagan_Selenium_Learning.WebDriverCommandsEx
{
    public class TitleEx
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
        public void performAction()
        {
            string ActualParentpageTitle = _driver.Title;
            Console.WriteLine("ActualParentpageTitle: " + ActualParentpageTitle);
            // string ExpectedPageTitle = "ParaBank | Welcome | Online Banking";

            //Assert.That(ActualpageTitle,Is.EqualTo(ExpectedPageTitle));

            // Assert.That(ActualpageTitle, Is.Not.EqualTo(ExpectedPageTitle));

            //string viewPagesource = _driver.PageSource;
            //Console.WriteLine("viewPagesource: " + viewPagesource);
            Thread.Sleep(5000);

            _driver.FindElement(By.XPath("//*[@id=\"content_wrapper\"]/section/div[4]/section/div[2]/div[1]/div/div[5]/a/div[3]/div[1]")).Click();
            Thread.Sleep(5000);
            string ActualChildpageTitle = _driver.Title;
            Console.WriteLine("ActualChildpageTitle: " + ActualChildpageTitle);
        }

        [TearDown]
        public void closseBrowser()
        {
            // _driver.Quit();
            _driver.Close();

        }
    }
}
