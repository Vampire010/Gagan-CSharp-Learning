using OpenQA.Selenium;
using SpecFlowProject1.Browser_Configuration;
using System;
using TechTalk.SpecFlow;
namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class LogInStepDefinitions
    {
        [Given(@"Navigate to LogInPage\(BrowserType, Url\)")]
        public void GivenNavigateToLogInPageBrowserTypeUrl( )
        {
            string BrowserType = "chrome";
            string TestURL = "https://katalon-demo-cura.herokuapp.com/";
            BrowserLauncher.openBrowser(BrowserType,TestURL);
        }

        [When(@"Verify user is On LogInPage")]
        public void WhenVerifyUserIsOnLogInPage()
        {
            BrowserLauncher.driver.FindElement(By.XPath("//*[@id=\"btn-make-appointment\"]")).Click();
        }

        [Then(@"Enetr the username\(userName\)")]
        public void ThenEnetrTheUsernameUserName()
        {
            BrowserLauncher.driver.FindElement(By.Id("txt-username")).SendKeys("John Doe");
        }

        [Then(@"Enter the Password\(usrPassword\)")]
        public void ThenEnterThePasswordUsrPassword()
        {
            BrowserLauncher.driver.FindElement(By.Name("password")).SendKeys("ThisIsNotAPassword");
        }

        [Then(@"Click on LogIn Button")]
        public void ThenClickOnLogInButton()
        {
            BrowserLauncher.driver.FindElement(By.XPath("//*[@id=\"btn-login\"]")).Click();
        }
    }
}
