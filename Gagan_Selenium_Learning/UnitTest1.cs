namespace Gagan_Selenium_Learning
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Launch Chrome Browser");
            Console.WriteLine("Navigate to https://parabank.parasoft.com/");
        }
        [TestCase("Vampire","!@#$@")]
        [TestCase("Devil", "!@Dev1234")]
        [TestCase("Ghost", "!@ght09876")]


        // [Test]
        public void Test1(string user , string userpassword)
        {
            Console.WriteLine("Enetr user name: " + user);
              Console.WriteLine("Enetr password : "+ userpassword);
        }
        [TearDown]
        public void TearDown() 
        {
            Console.WriteLine("Close the Browser");
        }
    }
}