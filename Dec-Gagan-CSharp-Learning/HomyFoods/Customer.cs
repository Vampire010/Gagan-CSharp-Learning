using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dec_Gagan_CSharp_Learning.HomyFoods
{
    public class Customer : Billing
    {
        public string customerID;
        public string customerName;
        public string address;
        public long conatctNumber;

        public const double discountforRegularCustomer = 10;
        public const double discountforPremiumCustomer = 20;
        public const double deliveryCharge = 20;


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

        public virtual double CustomerBilling(double price)
        {

            return (double)price;
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

        public void updateDetails(long conatctNumber)
        {
            this.conatctNumber=conatctNumber;
            Console.WriteLine("****************** Updated Customer conatctNumber***********************");
            Console.WriteLine("customerID: " + customerID);
            Console.WriteLine("customerName: " + customerName);
            Console.WriteLine("address: " + address);
            Console.WriteLine("conatctNumber: " + conatctNumber);
            Console.WriteLine("*****************************************");
        }
        public void updateDetails(string Address)
        {
            this.address=Address;
            Console.WriteLine("****************** Updated Customer Address ***********************");
            Console.WriteLine("customerID: " + customerID);
            Console.WriteLine("customerName: " + customerName);
            Console.WriteLine("address: " + address);
            Console.WriteLine("conatctNumber: " + conatctNumber);
            Console.WriteLine("*****************************************");

        }
        
    }
}

