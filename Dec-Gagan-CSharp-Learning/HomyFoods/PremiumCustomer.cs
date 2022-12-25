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
    }
}
