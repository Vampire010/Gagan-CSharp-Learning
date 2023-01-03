using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace Gagan_Selenium_Learning.WebDriverCommandsEx
{
    public class SelectOptionsEx
    {
        IWebDriver _driver;
        [SetUp]
        public void openBrowser()
        {
            // launch Empty Chrome Browser
            _driver = new ChromeDriver();

            //naviagte to Url
            _driver.Navigate().GoToUrl("file:///D:/Manual%20Testing%20Notes-20221205T232832Z-001/Manual%20Testing%20Notes/webiste/registration/index.html");
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
          IWebElement birtDate = _driver.FindElement(By.XPath("/html/body/form/fieldset[3]/p[2]/select[1]"));
          IWebElement birtYear = _driver.FindElement(By.XPath("/html/body/form/fieldset[3]/p[2]/select[2]"));
          IWebElement Nationality= _driver.FindElement(By.XPath("/html/body/form/fieldset[3]/p[3]/select"));


            SelectElement selectDate = new SelectElement(birtDate);
            selectDate.SelectByIndex(23);

            SelectElement selectbirtYear = new SelectElement(birtYear);
            selectbirtYear.SelectByValue("5");

            SelectElement selectNationality = new SelectElement(Nationality);
            selectNationality.SelectByText("United States");

           Thread.Sleep(5000);

        }
        [TearDown]
        public void TearDown()
        {
            _driver.Close();
        }
    }
}
