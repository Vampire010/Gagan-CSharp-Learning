using Dec_Gagan_CSharp_Learning.ControlFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dec_Gagan_CSharp_Learning.HomyFoods
{
    [TestClass]
    public class RuntestCustom
    {
        [TestMethod]
        public void TestRunner()
        {
            //Customer customer1 = new Customer();
            RegularCustomer reg = new RegularCustomer("C101", "John", "24th Street newtown", 9876543210);
            reg.displayCustomerDetails();
            reg.CustomerBilling(1000);
            reg.updateDetails(9776543211);
            reg.updateDetails("25th Street newtown");

         /*   PremiumCustomer premium = new PremiumCustomer("C102", "smith", "25th Street newtown", 9776543211);
            premium.displayCustomerDetails();
            premium.CustomerBilling(1000);

            GuestCustomer guest = new GuestCustomer("C103", "jay", "26th Street newtown", 9676543212);
            guest.displayCustomerDetails();
            guest.CustomerBilling(1000); */

        }

    }
}
