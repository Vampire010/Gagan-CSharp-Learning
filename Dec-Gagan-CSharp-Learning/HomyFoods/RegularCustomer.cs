using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec_Gagan_CSharp_Learning.HomyFoods
{
    public class RegularCustomer: Customer
    {   
        public RegularCustomer(string customerID, string customerName, string address, long conatctNumber) 
        {
            this.customerID = customerID;
            this.customerName = customerName;
            this.address = address;
            this.conatctNumber = conatctNumber;
            Console.WriteLine("******RegularCustomer*************");
        }

        override
        public double CustomerBilling(double price)
        {
            Console.WriteLine("******RegularCustomer Billing*************");

            Console.WriteLine("TotalPrice Before Discount: " + price);

            double totalprice = price - (price * discountforRegularCustomer / 100);
            Console.WriteLine("TotalPrice After Discount: " + totalprice);
            Console.WriteLine("************************************");

            return (double)price;

        }
    }
}