using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;

namespace Dec_Gagan_CSharp_Learning.CollectionsExample
{
    [TestClass]
    public class ArrayListEx
    {
        [TestMethod]
        public void TestMethod1()
        {
            ArrayList studentDetails= new ArrayList();
            studentDetails.Add(112);
            studentDetails.Add("John");
            studentDetails.Add(98);

            Console.WriteLine("****************************");
            for (int i = 0; i < studentDetails.Count; i++)
              {
                  Console.WriteLine(studentDetails[i]);

              }
            Console.WriteLine("****************************");

            studentDetails[1] = 12;

            // studentDetails.RemoveRange(0, studentDetails.Count);
            studentDetails.Remove(1);
            studentDetails.Reverse();
            studentDetails.Sort();

            Console.WriteLine("****************************");

            foreach (var details in studentDetails)
            {
                Console.WriteLine(details);

            }

            Console.WriteLine("****************************");
            Console.WriteLine(studentDetails.Contains(120));



        }
    }
}
