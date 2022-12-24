using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dec_Gagan_CSharp_Learning.HomyFoods
{
    class Customer
    {
        public string customerID;
        public string customerName;
        public string address;
        public long conatctNumber;

        public void displayCustomerDetails(string customerID , string customerName , string address , long conatctNumber)
        {

            this.customerID = customerID;
            this.customerName = customerName;
            this.address = address;
            this.conatctNumber= conatctNumber;

            Console.WriteLine("*****************************************");
            Console.WriteLine("customerID: " + customerID);
            Console.WriteLine("customerName: " + customerName);
            Console.WriteLine("address: " + address);
            Console.WriteLine("conatctNumber: " + conatctNumber);
            Console.WriteLine("*****************************************");
        }
    }
}

