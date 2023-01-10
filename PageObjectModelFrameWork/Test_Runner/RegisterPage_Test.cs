using PageObjectModelFrameWork.Browser_Configuration;
using PageObjectModelFrameWork.Parabank_Register_Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModelFrameWork.Test_Runner
{
    public class RegisterPage_Test
    {
        public static string testUrl = "https://parabank.parasoft.com/";
        public static string testBrowser = "chrome";


        [Test]
        public static void RegisterPage_Test_TC1()
        {
            BrowserLauncher.openBrowser(testBrowser, testUrl);
            Registerpage rgstr = new Registerpage(BrowserLauncher.driver);
            rgstr.clickRegisterlnk();
            rgstr.fisrtNameTbox("Gagan");
            rgstr.lastNameTbox("Deep");
            rgstr.addressTbox("#21 Gods Street");
            rgstr.cityTbox("Sydney");
            rgstr.StateTbox("NewSouthWales");
            rgstr.zipCodeTbox("123456");
            rgstr.phoneNumberTbox("9876543210");
            rgstr.ssnTbox("1234567890");
            rgstr.usernameTbox("gaganRocks122");
            rgstr.passwordTbox("gagan12313333");
            rgstr.repeatedPasswordTbox("gagan12313333");
            rgstr.submitBtn();
            Thread.Sleep(5000);
            BrowserLauncher.closeBrowser();

        }
    }
}
