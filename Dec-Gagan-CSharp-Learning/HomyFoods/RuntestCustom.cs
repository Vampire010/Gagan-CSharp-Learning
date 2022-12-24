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
            Customer customer = new Customer();
            customer.displayCustomerDetails("C101","John","24th Street newtown",9876543210);
            restoFoods res = new restoFoods();
            res.OrderFood("Juice");
            RuntestCustom ot = new RuntestCustom();
            ot.TestMethod1();
        }
    }
}
