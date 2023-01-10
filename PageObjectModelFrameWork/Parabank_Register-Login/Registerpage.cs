using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModelFrameWork.Parabank_Register_Login
{
    public class Registerpage
    {
        private IWebDriver driver;

        [FindsBy(How = How.LinkText, Using = "Register")]
        private IWebElement registerLnk { get; set; }

        [FindsBy(How = How.Id, Using = "customer.firstName")]
        private IWebElement frstName { get; set; }

        [FindsBy(How = How.Id, Using = "customer.lastName")]
        private IWebElement lastName { get; set; }

        [FindsBy(How = How.Id, Using = "customer.address.street")]
        private IWebElement address { get; set; }

        [FindsBy(How = How.Id, Using = "customer.address.city")]
        private IWebElement city { get; set; }

        [FindsBy(How = How.Id, Using = "customer.address.state")]
        private IWebElement state { get; set; }

        [FindsBy(How = How.Id, Using = "customer.address.zipCode")]
        private IWebElement zipCode { get; set; }


        [FindsBy(How = How.Id, Using = "customer.phoneNumber")]
        private IWebElement phoneNumber { get; set; }

        [FindsBy(How = How.Id, Using = "customer.ssn")]
        private IWebElement ssn { get; set; }

        [FindsBy(How = How.Id, Using = "customer.username")]
        private IWebElement username { get; set; }

        [FindsBy(How = How.Id, Using = "customer.password")]
        private IWebElement password { get; set; }

        [FindsBy(How = How.Id, Using = "repeatedPassword")]
        private IWebElement repeatedPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"customerForm\"]/table/tbody/tr[13]/td[2]/input")]
        private IWebElement submitButton { get; set; }

        [FindsBy(How = How.LinkText, Using = "Log Out")]
        private IWebElement LogOut { get; set; }

        public Registerpage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);        
        }

        public void clickRegisterlnk()
        {
            registerLnk.Click();
        }
        public void fisrtNameTbox(string value)
        {
            frstName.SendKeys(value);
        }
        public void lastNameTbox(string value)
        {
            lastName.SendKeys(value);
        }
        public void addressTbox(string value)
        {
            address.SendKeys(value);
        }

        public void cityTbox(string value)
        {
            city.SendKeys(value);
        }

        public void StateTbox(string value)
        {
           state.SendKeys(value);
        }

        public void zipCodeTbox(string value)
        {
            zipCode.SendKeys(value);
        }

        public void phoneNumberTbox(string value)
        {
            phoneNumber.SendKeys(value);
        }

        public void ssnTbox(string value)
        {
            ssn.SendKeys(value);
        }

        public void usernameTbox(string value)
        {
            username.SendKeys(value);
        }

        public void passwordTbox(string value)
        {
            password.SendKeys(value);
        }

        public void repeatedPasswordTbox(string value)
        {
            repeatedPassword.SendKeys(value);
        }

        public void submitBtn()
        {
            submitButton.Click();
        }

        public void logoutButton()
        {
            LogOut.Click();
        }
    }
}
