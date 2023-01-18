using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowProject1.Browser_Configuration;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class BookAppointmentStepDefinitions
    {
        LogInStepDefinitions lgn = new LogInStepDefinitions();

        [Given(@"Login to Application")]
        public void GivenLoginToApplication()
        {
            lgn.GivenNavigateToLogInPageBrowserTypeUrl();
            lgn.WhenVerifyUserIsOnLogInPage();
            lgn.ThenEnetrTheUsernameUserName();
            lgn.ThenEnterThePasswordUsrPassword();
            lgn.ThenClickOnLogInButton();
        }

        [Then(@"Choose the facility")]
        public void ThenChooseTheFacility()
        {
            IWebElement facilityOption = BrowserLauncher.driver.FindElement(By.XPath("//*[@id=\"combo_facility\"]"));
            SelectElement options = new SelectElement(facilityOption);
            options.SelectByText("Hongkong CURA Healthcare Center");

        }

        [Then(@"Apply for hospital readmission")]
        public void ThenApplyForHospitalReadmission()
        {
            IWebElement ApplyForHospitalReadmission = BrowserLauncher.driver.FindElement(By.XPath("//*[@id=\"chk_hospotal_readmission\"]"));
            ApplyForHospitalReadmission.Click();
        }

        [Then(@"Select the Healthcare Program")]
        public void ThenSelectTheHealthcareProgram()
        {
            IWebElement SelectTheHealthcareProgram = BrowserLauncher.driver.FindElement(By.XPath("//*[@id=\"radio_program_medicaid\"]"));
            SelectTheHealthcareProgram.Click();
        }

        [Then(@"Select Visit Date")]
        public void ThenSelectVisitDate()
        {
            IWebElement SelectVisitDate = BrowserLauncher.driver.FindElement(By.XPath("//*[@id=\"txt_visit_date\"]"));
            SelectVisitDate.SendKeys("19/01/2023");
        }

        [Then(@"Enter the Comment")]
        public void ThenEnterTheComment()
        {
            IWebElement EnterTheComment = BrowserLauncher.driver.FindElement(By.XPath("//*[@id=\"txt_comment\"]"));
            EnterTheComment.SendKeys("General Visit");
        }

        [Then(@"Click on Book Appointment")]
        public void ThenClickOnBookAppointment()
        {
            IWebElement ClickOnBookAppointment = BrowserLauncher.driver.FindElement(By.XPath("//*[@id=\"btn-book-appointment\"]"));
            ClickOnBookAppointment.Click();
        }
    }
}
