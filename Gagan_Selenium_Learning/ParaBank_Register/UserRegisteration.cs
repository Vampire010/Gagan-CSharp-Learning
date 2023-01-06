using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace Gagan_Selenium_Learning.ParaBank_Register
{
    public class UserRegisteration
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
            Thread.Sleep(4000);

        }


        [Test]
        public void Test1()
        {

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //LinkText
            /*IWebElement registerLnk = _driver.FindElement(By.LinkText("Register"));
            registerLnk.Click(); */

            IWebElement registerLnk = _driver.FindElement(By.PartialLinkText("Regis"));
            registerLnk.Click();

            IWebElement firstNameTbox = _driver.FindElement(By.Id("customer.firstName"));
            firstNameTbox.SendKeys("Rama");

            IWebElement lastNameTbox = _driver.FindElement(By.Id("customer.lastName"));
            lastNameTbox.SendKeys("Laxman");

            IWebElement addressTbox = _driver.FindElement(By.Name("customer.address.street"));
            addressTbox.SendKeys("#32,2nd Street, Mango Town");

            IWebElement cityTbox = _driver.FindElement(By.Name("customer.address.city"));
            cityTbox.SendKeys("Bangalore");

            IWebElement stateTbox = _driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/form/table/tbody/tr[5]/td[2]/input"));
            stateTbox.SendKeys("Karnataka");


            IWebElement zipCodeTbox = _driver.FindElement(By.XPath("//input[@name=\"customer.address.zipCode\"]"));
            zipCodeTbox.SendKeys("563125");


            IWebElement phoneTbox = _driver.FindElement(By.XPath("//input[contains(@id,\"customer.phoneNumber\")]"));
            phoneTbox.SendKeys("9876543210");

            IWebElement ssnTbox = _driver.FindElement(By.XPath("//input[@id=\"customer.ssn\" or @name=\"customer.ssn\"]"));
            ssnTbox.SendKeys("2133651412");

            IWebElement usernameTbox = _driver.FindElement(By.XPath("//input[@id=\"customer.username\" and @name=\"customer.username\"]"));
            usernameTbox.SendKeys("RamaLaxman4");

            IWebElement passwordTbox = _driver.FindElement(By.XPath("//*[@id=\"customer.password\"]"));
            passwordTbox.SendKeys("RamaLaxman1994");
           
            IWebElement confirmTbox = _driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/form/table/tbody/tr[12]/td[2]/input"));
            confirmTbox.SendKeys("RamaLaxman1994");

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            IWebElement submitBtn = wait.Until(ElementExists => ElementExists.FindElement(By.CssSelector("#customerForm > table > tbody > tr:nth-child(13) > td:nth-child(2) > input")));

            //IWebElement submitBtn = _driver.FindElement(By.CssSelector("#customerForm > table > tbody > tr:nth-child(13) > td:nth-child(2) > input"));
            submitBtn.Submit();


            Screenshot scrnshot = (_driver as ITakesScreenshot).GetScreenshot();
            scrnshot.SaveAsFile("screenshot.png", ScreenshotImageFormat.Png);
            scrnshot.SaveAsFile(@"C:\Users\giris\source\repos\Gagan-CSharp-Learning\Gagan_Selenium_Learning\Screnshots\UserRegistartion.jpeg");


        }
        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(6000);
            _driver.Close();
        }
    }
}
