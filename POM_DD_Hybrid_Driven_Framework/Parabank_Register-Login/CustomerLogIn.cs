using OpenQA.Selenium;
using POM_DD_Hybrid_Driven_Framework.TestDataAccess;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM_DD_Hybrid_Driven_Framework.Parabank_Register_Login
{
    public class CustomerLogIn
    {
        private IWebDriver driver;

        [FindsBy(How = How.Name, Using = "username")]
        private IWebElement username { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement password { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"loginPanel\"]/form/div[3]/input")]
        private IWebElement login { get; set; }

        public CustomerLogIn(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Userlogin( string usrName , string usrpassword)
        {
            username.SendKeys(usrName);
            password.SendKeys(usrpassword);
            login.Click();
        }

    }
}
