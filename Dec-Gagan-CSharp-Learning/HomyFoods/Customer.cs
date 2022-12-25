using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dec_Gagan_CSharp_Learning.HomyFoods
{
    public class Customer
    {
        public string customerID;
        public string customerName;
        public string address;
        public long conatctNumber;


        //No Argument Constructor
        public Customer()
        {
            Console.WriteLine("********************No Argument Constructor*********************");
        } 

        public Customer(string customerID, string customerName , string address, long conatctNumber)
        {
            this.customerID = customerID;
            this.customerName = customerName;
            this.address = address;
            this.conatctNumber = conatctNumber;
        }

        public void displayCustomerDetails()
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("customerID: " + customerID);
            Console.WriteLine("customerName: " + customerName);
            Console.WriteLine("address: " + address);
            Console.WriteLine("conatctNumber: " + conatctNumber);
            Console.WriteLine("*****************************************");
        }
    }
}

