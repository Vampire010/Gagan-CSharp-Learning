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
        
    }
}