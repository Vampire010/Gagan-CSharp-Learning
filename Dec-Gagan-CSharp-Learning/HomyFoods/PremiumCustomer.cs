using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec_Gagan_CSharp_Learning.HomyFoods
{
    public class PremiumCustomer : RegularCustomer
    {
        public PremiumCustomer(string customerID, string customerName, string address, long conatctNumber) : base(customerID, customerName, address, conatctNumber)
        {
            Console.WriteLine("******PremiumCustomer*************");

        }

        override
       public double CustomerBilling(double price)
        {
            Console.WriteLine("******PremiumCustomer Billing*************");

            Console.WriteLine("TotalPrice Before Discount: " + price);

            double totalprice = price - (price * discountforPremiumCustomer / 100);
            Console.WriteLine("TotalPrice After Discount: " + totalprice);
            Console.WriteLine("************************************");

            return (double)price;

        }
    }
}
