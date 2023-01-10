using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gagan_Selenium_Learning.IFrames
{
    public class iFramehandling
    {
        IWebDriver _driver;
        [SetUp]
        public void openBrowser()
        {
            // launch Empty Chrome Browser
            _driver = new ChromeDriver();

            //naviagte to Url
            _driver.Navigate().GoToUrl("file:///C:/Users/giris/source/repos/Gagan-CSharp-Learning/Gagan_Selenium_Learning/IFrames/Main.html");
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            

            IWebElement frame1 = _driver.FindElement(By.Id("Frame1"));
            int frame2 = 1;
            IWebElement frame3 = _driver.FindElement(By.XPath("//*[@id=\"Frame3\"]"));

            _driver.SwitchTo().Frame(frame1);
            IWebElement wikidataTxt = _driver.FindElement(By.XPath("//*[@id=\"mw-content-text\"]/div[1]/div/div[1]/div/p[1]/strong"));
            Console.WriteLine(wikidataTxt.Text);


            _driver.SwitchTo().DefaultContent();
            _driver.SwitchTo().Frame(frame2);
            IWebElement mediaWikiTxt = _driver.FindElement(By.XPath("//*[@id=\"firstHeading\"]/p"));
            Console.WriteLine(mediaWikiTxt.Text);

            _driver.SwitchTo().DefaultContent();
            _driver.SwitchTo().Frame(frame3);
            IWebElement metaWikiTxt = _driver.FindElement(By.XPath("//*[@id=\"Meta-Wiki\"]"));
            Console.WriteLine(metaWikiTxt.Text);

           
        }
        [TearDown]
        public void TearDown()
        {
            _driver.Close();
        }

    }
}
