using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gagan_Selenium_Learning.WebDriverCommandsEx
{
    public class MultiSelectEx
    {
        IWebDriver _driver;
        [SetUp]
        public void openBrowser()
        {
            // launch Empty Chrome Browser
            _driver = new ChromeDriver();

            //naviagte to Url
            _driver.Navigate().GoToUrl("file:///C:/Users/giris/source/repos/Gagan-CSharp-Learning/Gagan_Selenium_Learning/WebDriverCommandsEx/multiSelect.html");
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            IWebElement cars = _driver.FindElement(By.XPath("//*[@id=\"cars\"]"));
   


            SelectElement SelectCars = new SelectElement(cars);
            SelectCars.SelectByIndex(0);
            SelectCars.SelectByValue("saab");
            SelectCars.SelectByText("Audi");


            Thread.Sleep(5000);

            /*  SelectCars.DeselectByIndex(0);
              SelectCars.DeselectByValue("saab");
              SelectCars.DeselectByText("Audi"); */

            SelectCars.DeselectAll();
            Thread.Sleep(5000);


        }
        [TearDown]
        public void TearDown()
        {
            _driver.Close();
        }
    }
}
