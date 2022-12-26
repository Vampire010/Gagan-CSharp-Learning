using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec_Gagan_CSharp_Learning.HomyFoods
{
    public class GuestCustomer: Customer
    {
        public GuestCustomer(string customerID, string customerName, string address, long conatctNumber)
        {
            this.customerID = customerID;
            this.customerName = customerName;
            this.address = address;
            this.conatctNumber = conatctNumber;
            Console.WriteLine("******GuestCustomer*************");

        }
        override
     public double CustomerBilling(double price)
        {
            Console.WriteLine("******GuestCustomer Billing*************");

            Console.WriteLine("TotalPrice with out deliverCharge: " + price);

            double totalprice = price + deliveryCharge;
            Console.WriteLine("TotalPrice with deliverCharge: " + totalprice);
            Console.WriteLine("************************************");

            return (double)price;

        }
    }
}
