using POM_DD_Hybrid_Driven_Framework.Browser_Configuration;
using POM_DD_Hybrid_Driven_Framework.Parabank_Register_Login;
using POM_DD_Hybrid_Driven_Framework.TestDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM_DD_Hybrid_Driven_Framework.TestRunner
{
    public class LoginPagetest
    {
        public static string testUrl = "https://parabank.parasoft.com/";
        public static string testBrowser = "chrome";
        public  string usrname;
        public  string usrpassword;


        [Test]
        public  void LoginPagetest_tc01()
        {
            BrowserLauncher.openBrowser(testBrowser, testUrl);

            CustomerLogIn Usrlog_In = new CustomerLogIn(BrowserLauncher.driver);

            ExcelOperations.PopulateInCollection(@"C:\Users\giris\source\repos\Gagan-CSharp-Learning\POM_DD_Hybrid_Driven_Framework\TestDataAccess\TestData.xlsx");
            for (int i = 1; i <2 ; i++)
            {
                this.usrname = ExcelOperations.ReadData(i, "Username");
                Console.WriteLine(usrname);

                this.usrpassword = ExcelOperations.ReadData(i, "Password");
                Console.WriteLine(usrpassword);
            }
            Usrlog_In.Userlogin(usrname, usrpassword);

        }
    }
}
