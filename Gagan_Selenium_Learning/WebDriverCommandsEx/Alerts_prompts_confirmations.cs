using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Gagan_Selenium_Learning.WebDriverCommandsEx
{
    public class Alerts_prompts_confirmations
    {
        IWebDriver _driver;
        [SetUp]
        public void openBrowser()
        {
            // launch Empty Chrome Browser
            _driver = new ChromeDriver();

            //naviagte to Url
            _driver.Navigate().GoToUrl("https://www.selenium.dev/documentation/webdriver/interactions/alerts/");
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            IWebElement clickOnexampleAlert = _driver.FindElement(By.XPath("/html/body/div/div[1]/div/main/div/p[2]/a"));
            clickOnexampleAlert.Click();
            //Wait for the alert to be displayed and store it in a variable
            IAlert alert = _driver.SwitchTo().Alert();
            //Store the alert text in a variable
            string Alerttext = alert.Text;
            Console.WriteLine(Alerttext);
            //Press the OK button
            alert.Accept();
            Thread.Sleep(5000);

            IWebElement clickOnexampleConfirm = _driver.FindElement(By.XPath("/html/body/div/div[1]/div/main/div/p[4]/a"));
            clickOnexampleConfirm.Click();

            alert = _driver.SwitchTo().Alert();
            alert.Dismiss();

            Thread.Sleep(5000);

            IWebElement clickOnexamplePrompt = _driver.FindElement(By.XPath("/html/body/div/div[1]/div/main/div/p[6]/a"));
            clickOnexamplePrompt.Click();

            alert = _driver.SwitchTo().Alert();
            alert.SendKeys("Alerts");
            alert.Accept();

            Thread.Sleep(5000);


        }
        [TearDown]
        public void TearDown()
        {
            _driver.Close();
        }
    }
}
