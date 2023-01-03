using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gagan_Selenium_Learning.WebDriverCommandsEx
{
    public class VerifytheElements
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
        public void performAction()
        {
           IWebElement emailTbox = _driver.FindElement(By.XPath("/html/body/form/fieldset[1]/p[1]/input[1]"));

            Boolean isemailTboxEnabled = emailTbox.Enabled;
            Console.WriteLine("isemailTboxEnabled: " + isemailTboxEnabled);
           
           IWebElement repeatemailTbox = _driver.FindElement(By.XPath("/html/body/form/fieldset[1]/p[1]/input[2]"));

            Boolean isrepeatemailTboxEnabled = repeatemailTbox.Enabled;
            Console.WriteLine("isrepeatemailTboxEnabled :" + isrepeatemailTboxEnabled);

            Boolean isemailTboxDisplayed = emailTbox.Displayed;
            Console.WriteLine("isemailTboxDisplayed :" + isemailTboxDisplayed);


            repeatemailTbox.SendKeys("abc@xyz.com");
            Thread.Sleep(5000);
            repeatemailTbox.Clear();
            Thread.Sleep(5000);

        }

        [TearDown]
        public void closseBrowser()
        {
            // _driver.Quit();
            _driver.Close();

        }
    }
}
