using Dec_Gagan_CSharp_Learning.ControlFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dec_Gagan_CSharp_Learning.HomyFoods
{
    [TestClass]
    public class RuntestCustom: Outing //Inheritance
    {
        [TestMethod]
        public void TestRunner()
        {
            //Customer customer1 = new Customer();
            PremiumCustomer reg = new PremiumCustomer("C101", "John", "24th Street newtown", 9876543210);

            reg.displayCustomerDetails();
         
        }
    }
}
