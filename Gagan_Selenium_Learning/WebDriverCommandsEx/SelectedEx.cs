using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gagan_Selenium_Learning.WebDriverCommandsEx
{
    internal class SelectedEx
    {
        IWebDriver _driver;
        [SetUp]
        public void openBrowser()
        {
            // launch Empty Chrome Browser
            _driver = new ChromeDriver();

            //naviagte to Url
            _driver.Navigate().GoToUrl("file:///D:/Manual%20Testing%20Notes-20221205T232832Z-001/Manual%20Testing%20Notes/webiste/registration/index.html");
            Console.WriteLine("Before maximize:" + _driver.Manage().Window.Size);

            _driver.Manage().Window.Maximize();
        }


        [Test]
        public void Test1()
        {
            IWebElement maleRdioBtn = _driver.FindElement(By.XPath("/html/body/form/fieldset[3]/p[1]/input[1]"));

            Boolean maleRdioBtnSelected = maleRdioBtn.Selected;

            Console.WriteLine("maleRdioBtnSelected: " + maleRdioBtnSelected);
            Thread.Sleep(4000);
            if (maleRdioBtnSelected==false)
            {
                maleRdioBtn.Click();
            }

            maleRdioBtnSelected = maleRdioBtn.Selected;

            Console.WriteLine("maleRdioBtnSelected: " + maleRdioBtnSelected);
            Thread.Sleep(4000);

            Console.WriteLine("After maximize:" + _driver.Manage().Window.Size);


        }
        [TearDown]
        public void TearDown()
        {
            // Console.WriteLine("Close the Browser");
            _driver.Close();
        }
    }
}
