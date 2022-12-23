using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dec_Gagan_CSharp_Learning.HomyFoods
{
    [TestClass]
    public class sampleTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            long[] contactNumbers = new long[3];
            contactNumbers[0] = 9876543210;
            contactNumbers[1] = 9876543211;
            contactNumbers[2] = 9876543212;

            foreach (long num in contactNumbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine(contactNumbers[3]);

        }
    }
}
